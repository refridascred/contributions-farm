using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }
    }
}
