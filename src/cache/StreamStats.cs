using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
