using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class LongestSubstring
    {
        public int FindLongestSubstringWithoutRepeatingCharacters(string input)
        {
            int maxLen = 0;
            HashSet<char> result = new HashSet<char>();
            int i = 0;
            int j = 0;

            if (input.Length < 1)
            {
                return 1;
            }

            while (i < input.Length)
            {
                if (!result.Contains(input[i]))
                {
                    result.Add(input[i]);
                    i++;
                    maxLen = Math.Max(result.Count, maxLen);
                }
                else
                {
                    result.Remove(input[j]);
                    j++;
                }
             }
            return maxLen;
        }
            
        
    }
}
