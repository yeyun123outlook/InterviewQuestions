using System;

/// <summary>
/// 面向对象编程思想
/// </summary>
namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入老虎对象的体重和长度（逗号分隔的整数）：");
            string input = Console.ReadLine();
            int pos = input.IndexOf(",");
            string w = input.Substring(0,pos);
            string l = input.Substring(pos+1);
            Tiger chinatiger = new Tiger(w,l);
            Console.WriteLine("老虎已经创建完成！");
            Console.WriteLine("这只老虎的重量是："+ chinatiger.Weight+"kg");
            Console.WriteLine("这只老虎的长度是" + chinatiger.Length + "cm");
            Console.WriteLine("老虎的特征是："+Tiger.msg);
            Console.WriteLine("老虎一般生存在："+Tiger.habitat);
            Console.WriteLine("老虎像猫吗？"+Tiger.cat());
        }
    }

    /// <summary>
    /// 哺乳动物类名称
    /// </summary>
    class Mammal
    {
        protected static bool viviparous = true;  //有胎生的特征
        protected static bool Feeding = true; //有喂养的特征
    }
    /// <summary>
    /// 猫科动物类名称（继承于哺乳动物类）
    /// </summary>
    class Felid : Mammal
    {
        protected static bool catlike = true; //类似猫的特征
        protected static bool sensitivity = true; //有敏感的特征
    }
    /// <summary>
    /// 虎类名称（继承于猫科动物类）
    /// </summary>
    class Tiger : Felid
    {
        //有各种特征
        internal static string msg = "凶猛、会游泳、会爬树，有漂亮的花纹，被称为“兽中之王”。";
        internal static string habitat = "森林";  //栖息地在森林
       

        public string Weight { get; set; }//体重
        public string Length { get; set; }//长度

        
        internal Tiger(string w, string l)  //构造函数，直接给体重和长度赋值
        {
            Weight = w;
            Length = l;
        }
        /// <summary>
        /// 通过静态方法获取继承的属性
        /// </summary>
        /// <returns></returns>
        internal static bool cat()  
        {
            return Tiger.catlike;
        }
    }
}
