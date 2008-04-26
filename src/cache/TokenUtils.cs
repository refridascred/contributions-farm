using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long step, long offset)
        {
            long cur = step - offset;
            if ((20.0 / 2.0) == (double)cur)
            {
                return 8;
            }
            else
            {
                if ((3.0 - 8.54) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long MeasureCounterProfileOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits >> 3) == (35 + sample)) && ((hits * 2) >= 67))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 3718;
        public const long BatchStream = 5541;
        public const double WindowStream = 83.85;
        public const long RetryStream = 4539;
        public const long BaseBudget = 7770;
    }
}
