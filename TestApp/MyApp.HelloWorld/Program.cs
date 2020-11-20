using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyApp.HelloWorld
{
    public class Test
    {
        public int id {get; set;}
        public string name {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Test> t = new List<Test>() {
                new Test(){id=1,name="车辆"},
                new Test(){id=2,name="车辆"},
                new Test(){id=3,name="飞机"},
                new Test(){id=4,name="火车"},
                new Test(){id=4,name="火车"},
                 new Test(){id=5,name="火车1"},
                new Test(){id=5,name="火车1"},
            };
            //同名
            var q = t.GroupBy(x => x.id).Where(x => x.Count() > 1).ToList();
            var ff = q.Select(t => t.Key).ToArray();
            Console.Write(string.Join(",/r/n", ff));

            Console.WriteLine("==================");
            foreach (var item in q)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("==================");
            Regex reg = new Regex(@"^[0-9.]+$");
            List<string> num = new List<string>{"123", "123.4"};
            foreach(string s in num)
            {
                Console.WriteLine(s + "=="+ reg.IsMatch(s).ToString());
            }
            Console.WriteLine("==================");

            reg = new Regex(@"^[A-Z]+\d+$");
            num = new List<string>{"E76","TT453", "U788U","R123-Z123", "Z12~R34"};
            Regex reg2 = new Regex(@"[A-Z]+");
             foreach(string s in num)
            {
                Console.WriteLine(s + "=="+ reg.IsMatch(s).ToString() + "==" +  reg2.Match(s).Value);
            }
            int a = 1; int b =1;
            for(int i = a; i <= b; i++)
            {
                Console.WriteLine(i + "=========");
            }

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            dic.Add("1", new List<string>{"a","b","c"});
            dic.Add("2", new List<string>{"d","e","f"});
            dic.Add("3", new List<string>{"h"});
            dic.Add("4", new List<string>{"a","b"});

            var dicc = dic.Where(t => t.Value.Count >=2).ToList();
        }
    }
}
