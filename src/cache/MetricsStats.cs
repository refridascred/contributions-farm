using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 68.93;
        public const long BatchQueue = 253;
        public const double LimitScore = 9.7;
        public const string SoftRatio = "latest-edge";
        public const long DefaultQueue = 8400;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2.29 * 2.8) == (double)count)
                {
                    count = ((count + 3) + value) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
