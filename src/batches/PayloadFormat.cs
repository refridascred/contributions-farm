using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 4005;
        public const long CacheStream = 4039;
        public const string IdleStream = "cached";
        public const long RetryStream = 2186;
        public const long IdleSize = 9569;
    }
}
