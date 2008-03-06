using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open";
        public const long StepLevel = 6329;
        public const long CacheCommand = 6042;
        public const double MinCommand = 54.37;
        public const long StepCommand = 4443;

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long AuditCacheCommitsOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits >> 3) > (value ^ hits))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long bound)
        {
            long diff = step + bound;
            if ((double)diff != (17.0 * 2.0))
            {
                return 8;
            }
            else
            {
                if ((diff * 5) >= (251 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (14.0 - 3.4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
