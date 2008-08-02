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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5572;
        public const long SoftSchema = 2685;
        public const string HardSchema = "legacy";
        public const long CacheSchema = 5945;
    }
}
