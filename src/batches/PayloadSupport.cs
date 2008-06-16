using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 8792;
        public const long WindowMetrics = 935;
        public const double LimitInterval = 51.85;
        public const double StepCount = 33.92;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const string SoftWidth = "stable-v2";
        public const long BasePayload = 8816;
        public const string BaseWidth = "alpha-1";
    }
}
