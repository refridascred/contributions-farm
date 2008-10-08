using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8155;
        public const long DefaultQueue = 7922;
        public const double HardWidth = 77.01;
        public const long BurstTimeout = 5649;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySize = 7575;
        public const long RetryNotes = 17;
        public const double WindowTimeout = 91.74;
        public const long StepLevel = 7047;
        public const long BaseScore = 9818;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
