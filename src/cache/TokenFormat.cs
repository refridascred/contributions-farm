using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const double IdleMetric = 29.18;
        public const string HardMetric = "local";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
