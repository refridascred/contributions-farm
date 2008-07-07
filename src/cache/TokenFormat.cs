using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 8878;
        public const long WindowScore = 2192;
        public const string SoftScore = "fallback";
    }
}
