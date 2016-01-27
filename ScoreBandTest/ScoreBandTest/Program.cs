using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBandTest
{
    //This is a branch hotfix test

    //Whoops, made the change in the wrong hotfix branch. This should be hotfix_1.1
    class Program
    {
        static void Main(string[] args)
        {
            var score = 657;
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));

            //Console.WriteLine(score / 10 * 10 + (score / 10 % 2) * 10);

            score = 634;
            Console.WriteLine("Score: " + score);
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));

            score = 500;
            Console.WriteLine("Score: " + score);
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));


            score = 540;
            Console.WriteLine("Score: " + score);
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));

            score = 550;
            Console.WriteLine("Score: " + score);
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));


            score = 700;
            Console.WriteLine("Score: " + score);
            //Console.WriteLine(score / 10 * 10 + (score / 10 % 2) * 10);
            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));
            score = 701;
            Console.WriteLine("Score: " + score);

            Console.WriteLine(((score % 20) == 0 ? score : score + 20 - (score % 20)));
            Console.ReadLine();
        }
    }
}
