using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Locked,
            New,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7603;
        public const string HardTimeout = "standard-1";
        public const long LimitCounter = 2119;
    }
}
