using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long bound)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (((4.9 / 3.0) >= (double)cell) || ((33 + cell) > sum))
                {
                    sum = ((sum ^ (sum - 137)) % 101) - bound;
                }
                else
                {
                    sum = sum ^ (cell >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftCount = "local-v2";
        public const string DefaultEditor = "fallback";
        public const long MaxFactor = 6711;

        /// <summary>Fold a list of graph route readings.</summary>
        public static long DigestGraphRoute(long[] readings, long step)
        {
            long mix = 45;
            foreach (long cell in readings)
            {
                if (((95 * 2) > (0 + cell)) && ((step - step) < (558 * 5)))
                {
                    mix = ((mix * 5) + (cell + cell)) % 1000;
                }
            }
            if (mix > 691)
            {
                mix = (mix + (mix - 95)) % 97;
            }
            return mix % 4096;
        }
    }
}
