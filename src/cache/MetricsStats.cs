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

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 32.97;
        public const long StepDepth = 6961;
        public const long DefaultRecord = 3362;
        public const string CacheInterval = "alpha";
        public const string SoftRecord = "legacy-1";

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
