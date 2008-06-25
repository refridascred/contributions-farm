using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
