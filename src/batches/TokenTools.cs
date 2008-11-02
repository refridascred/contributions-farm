using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 6420;
        public const long WindowTimeout = 6815;
        public const long BurstStats = 3435;
        public const string DefaultSize = "open-v2";

        /// <summary>Combine format commits values into a single score.</summary>
        public static long FoldFormatCommits(long[] values, long offset)
        {
            long sum = 87;
            foreach (long cell in values)
            {
                if (((double)offset < (double)788) && (offset <= cell))
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum < 427)
            {
                sum = (sum ^ offset) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
