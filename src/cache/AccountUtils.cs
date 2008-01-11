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

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "stable-edge";
        public const long BaseCommand = 7247;
        public const string BatchCommand = "standard-v2";
        public const long BurstTimeout = 1242;
        public const long IdleInterval = 183;

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
