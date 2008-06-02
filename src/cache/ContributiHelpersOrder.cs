using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "staging-v2";
        public const long StepSpan = 4730;
        public const long StepMetric = 3580;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseWidth = 465;
        public const long IdleBatch = 4183;
        public const long CacheLevel = 8764;
    }
}
