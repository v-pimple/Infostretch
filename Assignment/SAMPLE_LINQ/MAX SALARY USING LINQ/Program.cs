using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace MAX_SALARY_USING_LINQ
{
    public class student
    { 
    public int id { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> stdlist = new List<student>()
            { 
            new student (){ id=1,name="vaibhav"},
            new student (){ id=2,name="prashant"},
                new student (){ id=3,name="rohit"},
            new student (){ id=4,name="vishal"},
            };

            var result = stdlist.OrderBy(s => s.id).ToList();
            foreach (var s in result)
            {
                Console.WriteLine(s.name);
            }
            Console.ReadLine();
        }
    }
}
