using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count context cluster pairs that satisfy a relation.</summary>
        public static long MatchContextClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5268;
        public const long DefaultAlready = 696;
        public const string BaseInterval = "primary-1";
        public const double BatchSize = 24.24;
        public const long SoftBudget = 3522;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 329;
        public const long LimitChannel = 4120;
        public const long BurstChannel = 1439;
        public const long CacheTimeout = 9540;
        public const string HardChannel = "alpha-v2";
    }
}
