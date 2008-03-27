using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 3239;
        public const string IdleWindow = "standard-v2";
        public const string HardSpan = "stable";
        public const long StepWindow = 3585;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheRatio = "fallback-1";
        public const long WindowBatches = 8554;
        public const double BurstFactor = 52.65;
    }
}
