using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 94.85;
        public const long BaseMetric = 7152;
        public const long MinMetric = 8102;
        public const string IdleCount = "local-1";
        public const string MinTimeout = "local-v2";

        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool CheckChecksReportRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 5.17;
        public const long IdleLevel = 4256;
        public const long IdleRatio = 7752;
        public const long HardEntry = 4265;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Closed,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
