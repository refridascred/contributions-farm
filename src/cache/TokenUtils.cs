using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((step + datum) <= (7 << 3)) || (datum >= (seen + datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long AuditContributiSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - matches) <= 810)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long seed)
        {
            if ((4.49 * 2.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (121 <= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
