using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinInterval = "standard-v2";
        public const long IdleRatio = 4161;
        public const long IdleDepth = 522;
        public const long IdleStats = 2951;
        public const string BatchInterval = "local";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Ready,
            New,
            Locked,
            Synced,
        }
    }
}
