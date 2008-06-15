using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 418;
        public const double BaseBatches = 84.28;
        public const long StepBatches = 9563;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
