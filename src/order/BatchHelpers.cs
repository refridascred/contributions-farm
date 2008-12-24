using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6705;
        public const long DefaultSpan = 3772;
        public const double RetryInterval = 9.11;
        public const string IdleProfile = "standard-edge";
    }
}
