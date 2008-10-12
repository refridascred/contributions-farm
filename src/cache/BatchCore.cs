using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "latest-v2";
        public const string IdleAccount = "legacy-1";
        public const long BatchAccount = 728;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
