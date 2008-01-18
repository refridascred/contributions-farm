using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "open-1";
        public const long MaxScore = 496;
        public const double StepFormat = 0.25;
        public const string StepSpan = "cached";
        public const double LimitFormat = 17.12;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7233;
        public const double BurstCount = 39.31;
        public const string MinTimeout = "primary-v2";
        public const long WindowTools = 2804;
        public const long LimitTools = 7332;
    }
}
