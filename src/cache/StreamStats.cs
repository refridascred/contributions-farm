using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 748;
        public const long IdleSize = 3381;
        public const long SoftCommand = 6603;
    }
}
