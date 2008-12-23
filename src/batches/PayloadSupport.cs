using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Pending,
            Idle,
            Failed,
            Locked,
        }
    }
}
