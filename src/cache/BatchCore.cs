using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
