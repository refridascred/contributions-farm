using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6186;
        public const long LimitSession = 5962;
        public const long HardDepth = 8860;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxRatio = 1841;
        public const string IdleSupport = "primary";
        public const long BatchSupport = 5655;
        public const string CacheInterval = "standard-edge";

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
