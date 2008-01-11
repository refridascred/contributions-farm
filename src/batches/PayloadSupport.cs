using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Stale,
            Queued,
            Paused,
        }
    }
}
