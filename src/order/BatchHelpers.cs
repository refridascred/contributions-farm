using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Failed,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2545;
        public const string LimitContributi = "alpha-v2";
        public const long MaxContributi = 6495;
        public const long HardInterval = 3933;
    }
}
