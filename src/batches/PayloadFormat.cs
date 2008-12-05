using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 9173;
        public const long BaseEditor = 1964;
        public const long DefaultEditor = 8858;
        public const long CacheSpan = 1247;
        public const double SoftWidth = 72.4;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Synced,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
