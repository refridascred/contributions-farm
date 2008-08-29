using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = (double)(222 + (-75));
            if (gain > (double)416)
            {
                gain = ((gain + (double)52) + scale) + floor;
            }
            return gain + (double)893;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheWidth = "stable";
        public const long RetryLevel = 5156;
        public const long MinRecord = 9615;
        public const long StepLevel = 2221;
        public const double DefaultBudget = 40.15;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3341;
        public const long IdleProfile = 5820;
        public const string WindowTimeout = "local-v2";
        public const long MinProfile = 810;

        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Active,
            Synced,
            Locked,
        }
    }
}
