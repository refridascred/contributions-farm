using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            New,
            Idle,
        }
    }
}
