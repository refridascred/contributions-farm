using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 4547;
        public const string StepRatio = "legacy-v2";
        public const string HardWidth = "local-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "stable";
        public const string CacheBudget = "stable";
        public const string WindowStream = "legacy-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
