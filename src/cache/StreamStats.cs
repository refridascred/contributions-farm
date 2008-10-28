using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Queued,
            Synced,
            New,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3861;
        public const long CacheFormat = 8246;
        public const long SoftFormat = 3767;
    }
}
