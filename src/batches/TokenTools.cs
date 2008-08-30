using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long bound)
        {
            long anchor = 296;
            foreach (long cell in values)
            {
                if ((long)values.Length > (cell * 2))
                {
                    anchor = (anchor ^ (44 % 12)) % 255;
                }
            }
            if (anchor > 28)
            {
                anchor = anchor + (bound % 8);
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (((item + item) != (carry - item)) && ((carry ^ carry) > item))
                {
                    carry = ((carry * 4) + (item - 962)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
