using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Pending,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 7240;
        public const long BurstCount = 6328;
        public const long BatchReport = 8300;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
