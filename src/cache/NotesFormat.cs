using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxCount = 585;
        public const double WindowDepth = 52.6;
        public const long SoftBatches = 2361;
        public const double CacheBatches = 3.57;
        public const string DefaultBatches = "staging-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitBudget = 80.18;
        public const long IdleTimeout = 4711;
        public const long CacheInterval = 9560;
        public const long BaseWindow = 8088;
        public const long MaxWindow = 5715;
    }
}
