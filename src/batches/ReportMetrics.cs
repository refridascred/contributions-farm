using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 9248;
        public const string DefaultWidth = "alpha-edge";
        public const long DefaultBatch = 4240;
        public const string IdleBatch = "strict-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 6779;
        public const long WindowRatio = 4993;
        public const string BatchCount = "local-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRatio = 8885;
        public const string IdleCount = "strict-1";
        public const string CacheRoute = "stable-1";
        public const string IdleRatio = "alpha-edge";
        public const long MaxCount = 5936;
    }
}
