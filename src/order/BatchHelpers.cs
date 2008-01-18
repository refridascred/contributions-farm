using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a metric filter reading by value.</summary>
        public static long LookupMetricFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9701;
        public const long HardContributi = 7376;
        public const string LimitContributi = "fallback";
        public const double StepSize = 11.06;
        public const long IdleContributi = 3215;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7233;
        public const double BurstCount = 39.31;
        public const string MinTimeout = "primary-v2";
        public const long WindowTools = 2804;
        public const long LimitTools = 7332;
    }
}
