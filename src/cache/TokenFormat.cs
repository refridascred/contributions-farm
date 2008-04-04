using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Paused,
            Failed,
            Queued,
        }
    }
}
