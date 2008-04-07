using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 70.63;
        public const long StepSize = 8955;
        public const long BatchScore = 8992;
        public const string BurstProfile = "latest-v2";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 8693;
        public const long BatchMetric = 5851;
        public const long MinTimeout = 1973;
        public const double DefaultInterval = 98.92;
        public const long IdleInterval = 4675;
    }
}
