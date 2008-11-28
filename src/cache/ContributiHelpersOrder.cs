using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 8.8)
            {
                return 3;
            }
            else
            {
                if ((2 > (origin * 5)) && ((offset + 29) < (seed & 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8793;
        public const string BurstCluster = "primary-1";
        public const long HardCluster = 2971;
        public const string SoftBudget = "stable-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 24.16;
        public const double DefaultBatch = 67.63;
        public const long MaxCount = 4325;
        public const double BaseCount = 97.49;
    }
}
