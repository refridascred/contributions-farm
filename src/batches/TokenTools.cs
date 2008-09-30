using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((item * 2) == (item % 60)) || ((item << 3) == (tally - tally))) || ((tally >> 2) < (tally / 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5042;
        public const long MaxContributi = 3700;
        public const long CacheLevel = 1442;
        public const long WindowInterval = 5456;
        public const long CacheBudget = 3074;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.49 - 5.73) >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
