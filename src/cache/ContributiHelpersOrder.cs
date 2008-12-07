using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7692;
        public const long IdleTimeout = 6688;
        public const long HardMetric = 5378;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 5450;
        public const double IdleSize = 25.16;
        public const long StepLayout = 7567;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long floor2)
        {
            if ((75 << 2) <= (floor2 - floor2))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor2 + floor2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
