using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            New,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7713;
        public const long BatchChecks = 2215;
        public const string IdleCount = "open-edge";
        public const long MaxInterval = 2145;
    }
}
