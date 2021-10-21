using System;

namespace string_manipulation_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //watch youtube video on string manipulation

            string text = "  THIS is MY Test Sentence.  ";
            string modifiedTextLower;
            string modifiedTextUpper;
            int modifiedTextLength;
            string modifiedTextTrim;
            string modifiedTextSub;


            modifiedTextLower = text.ToLower();
            modifiedTextUpper = text.ToUpper();
            modifiedTextLength = text.Length;
            modifiedTextTrim = text.Trim();
            modifiedTextSub = text.Substring(7);


            Console.WriteLine(modifiedTextLower);
            Console.WriteLine(modifiedTextUpper);
            Console.WriteLine(modifiedTextTrim);
            Console.WriteLine(modifiedTextSub);
            Console.WriteLine(modifiedTextLength);



            string x = "dkjf;aldkjf;kj:LKJ :LKJ:LH:LKJ:LKJHHH:KH:LKH";
            int textLength = x.Length;
            Console.WriteLine(textLength);


        }
    }
}
