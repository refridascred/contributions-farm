using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "strict-1";
        public const long IdleCount = 1462;
        public const long MinStats = 1229;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
