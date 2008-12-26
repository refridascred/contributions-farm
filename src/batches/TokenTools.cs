using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ (offset * 3)) % 1000) ^ entry;
                if ((double)offset == (4.19 + 7.71))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 2415;
        public const double HardSpan = 56.33;
        public const double HardEntry = 60.9;
        public const string CacheEntry = "local";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= (value / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
