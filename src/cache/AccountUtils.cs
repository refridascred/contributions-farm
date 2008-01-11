using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowTimeout = 1758;
        public const string CacheAlready = "staging-edge";
        public const string IdleAlready = "stable";
        public const long DefaultScore = 1296;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
