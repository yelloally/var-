using System;
using System.Text;

namespace var_keyword
{

    class keywordVar
    {

        static void Main(string[] args)
        {

            var a = 120.23f;
            var b = 150.23m;
            var c = 'G';
            var d = "yelloally";

            // to print their type of variables
            Console.WriteLine("value of c {0}, type {1}", a, a.GetType());
            Console.WriteLine("value of d {0}, type {1}", b, b.GetType());
            Console.WriteLine("value of e {0}, type {1}", c, c.GetType());
            Console.WriteLine("value of f {0}, type {1}", d, d.GetType());

            
            Console.ReadLine();
        }
    }
}

