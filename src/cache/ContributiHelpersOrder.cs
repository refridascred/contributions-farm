using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Dropped,
            Synced,
        }
    }
}
