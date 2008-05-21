using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Stale,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Locked,
            Closed,
            Draft,
        }
    }
}
