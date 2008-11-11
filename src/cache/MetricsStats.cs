using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftCount = "legacy-v2";
        public const string MaxFormat = "stable-edge";
        public const long BaseSpan = 7492;
        public const string HardInterval = "latest-v2";
        public const long MaxLevel = 8714;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinCount = "local-edge";
        public const double CacheSize = 87.7;
        public const double WindowTimeout = 34.94;
        public const long BurstTools = 179;
    }
}
