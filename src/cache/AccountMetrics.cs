using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-210) + floor) == (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheScore = 9746;
        public const long IdleAlready = 9041;
        public const string DefaultAlready = "staging-v2";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((origin + origin) > 76))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 8338;
        public const long CacheLevel = 9633;
        public const long DefaultFactor = 1918;
        public const string RetryInterval = "staging-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long SoftMetrics = 2541;
        public const string MinMetrics = "strict-v2";
        public const long DefaultRatio = 6216;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
