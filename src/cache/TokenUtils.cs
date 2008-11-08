using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item - item) < (tally << 2)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long seed)
        {
            if ((45 - seed) < 20)
            {
                return 5;
            }
            else
            {
                if (seed > (seed + 51))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) || (bound <= (seed * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const long MinCounter = 434;
        public const long BurstRatio = 912;
        public const long CacheRatio = 1553;
    }
}
