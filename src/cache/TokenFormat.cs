using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long seed2)
        {
            long gap = seed + seed2;
            if ((seed + gap) < (35 % 64))
            {
                return 1;
            }
            else
            {
                if (((6 + gap) >= (seed2 + seed)) || ((seed2 + seed2) > gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long AuditCacheMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + cell) >= 55) && ((cell + cell) != (cell - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
