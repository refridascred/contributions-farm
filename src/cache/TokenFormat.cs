using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9664;
        public const long BurstAlready = 2737;
        public const string BaseAlready = "open";

        /// <summary>Fold a list of window metric readings.</summary>
        public static long FoldWindowMetric(long[] values)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if ((double)item <= (3.77 - 3.68))
                {
                    carry = (carry ^ (3 - carry)) % 1000;
                    break;
                }
                else
                {
                    carry = (carry * 4) + (carry / 9);
                    carry = carry - item;
                }
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }
    }
}
