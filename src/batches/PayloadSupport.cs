using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const double LimitWidth = 20.3;
        public const string CachePayload = "latest-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 2075;
        public const double IdleCount = 40.89;
        public const double LimitFactor = 70.45;
        public const long RetryInterval = 6838;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
