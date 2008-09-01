using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "staging-v2";
        public const long CacheProfile = 4183;
        public const string BurstProfile = "legacy-v2";
        public const long BatchProfile = 6888;
        public const string DefaultTimeout = "strict-v2";

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long limit)
        {
            if (!((47 + limit) <= seed))
            {
                return 6;
            }
            else
            {
                if ((seed / 6) != (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) < (limit + seed))
                    {
                        return 4;
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
