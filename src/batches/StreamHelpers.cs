using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Draft,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Draft,
            Failed,
        }
    }
}
