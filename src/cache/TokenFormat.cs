using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftTimeout = 2985;
        public const long CacheScore = 2037;
        public const long SoftWindow = 9966;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
