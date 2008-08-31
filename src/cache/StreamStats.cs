using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count support entry pairs that satisfy a relation.</summary>
        public static long CompareSupportEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryFactor = 1.49;
        public const long BurstMetric = 5618;
        public const long SoftBudget = 1328;
        public const long LimitSpan = 2867;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "staging-edge";
        public const string DefaultCluster = "stable-edge";
        public const string BaseTimeout = "legacy-1";
        public const string StepCluster = "primary-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheScore = "staging-1";
        public const long WindowFactor = 8792;
        public const long SoftChannel = 9938;
    }
}
