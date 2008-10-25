using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6732;
        public const long BurstCluster = 4037;
        public const long RetryTimeout = 438;
        public const long MinInterval = 8878;
        public const string HardLevel = "cached-v2";

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (1.7 - bias))
            {
                bias2 = (bias2 - (10.0 * 9.4)) + ratio;
            }
            else
            {
                bias2 = bias2 - 1.0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)5;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Closed,
            Stale,
        }
    }
}
