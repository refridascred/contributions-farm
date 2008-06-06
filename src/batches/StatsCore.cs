using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 7291;
        public const long BurstSpan = 8230;
        public const long BatchScore = 292;
        public const long CacheScore = 1047;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7693;
        public const double BurstAccount = 68.6;
        public const string HardBudget = "cached-edge";
        public const string HardAccount = "standard";

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 6096;
        public const long IdleGraph = 1715;
        public const long BurstGraph = 1583;
        public const long CacheGraph = 6009;
        public const long RetryGraph = 4046;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 1034;
        public const double LimitFactor = 31.85;
        public const double StepBudget = 53.41;

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftCount = "open";
        public const long MaxFactor = 4349;
        public const long BurstSize = 5297;
    }
}
