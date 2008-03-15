using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleWidth = 90.88;
        public const long SoftMetric = 3103;
        public const double MinMetric = 98.98;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Stale,
            Draft,
            Synced,
            New,
        }
    }
}
