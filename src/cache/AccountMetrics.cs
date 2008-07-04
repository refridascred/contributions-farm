using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9720;
        public const long IdleMetrics = 3338;
        public const string BatchMetrics = "cached-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitFactor = 1407;
        public const string IdleBatch = "fallback-v2";
        public const long WindowBatch = 1616;
        public const double BatchWidth = 3.66;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "legacy-1";
        public const long BurstTimeout = 8791;
        public const long MaxCommand = 413;
        public const long RetryScore = 2966;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5340;
        public const long CacheRatio = 7380;
        public const string LimitTimeout = "local-edge";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
