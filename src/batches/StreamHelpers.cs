using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "open-v2";
        public const long HardInterval = 5971;
        public const long BatchMetrics = 2019;
        public const long CacheDepth = 1267;
        public const string StepMetrics = "legacy-1";

        /// <summary>Look up the position of a session githubfarm sample.</summary>
        public static long LookupSessionGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleDepth = 33.9;
        public const double WindowEntry = 18.22;
        public const long MaxSpan = 5173;
        public const long MaxScore = 1045;
        public const long BatchEntry = 9603;

        /// <summary>Compare every pair of order support readings.</summary>
        public static long OverlapOrderSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 3) <= cell) || ((count + count) > cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "cached";
        public const long BurstTimeout = 9372;
        public const string CacheContext = "fallback";
        public const long BaseSpan = 5622;
    }
}
