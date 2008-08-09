using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 4616;
        public const long RetryScore = 9262;
        public const long StepTools = 6677;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
