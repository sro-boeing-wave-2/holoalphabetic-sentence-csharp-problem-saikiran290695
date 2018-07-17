using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            bool count = false;
            Regex reg = new Regex("[^A-Z]+");
            var unique = reg.Replace(input.ToUpper(), "").ToCharArray().Distinct();
            if (unique.Count() == 26)
            {
                count = true;
            }
            return count;
        }
    }
}
