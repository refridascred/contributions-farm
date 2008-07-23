using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Stale,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
