using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 7806;
        public const long BurstChecks = 1336;
        public const long CacheChecks = 5986;
        public const string StepChecks = "cached";
        public const string LimitSpan = "strict";

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 70.44;
        public const long IdleDepth = 1120;
        public const long BatchTimeout = 2886;
        public const string BurstTimeout = "stable-edge";
        public const long StepBudget = 1742;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
