using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 33.95;
        public const double BaseFactor = 24.81;
        public const double RetryMetrics = 34.49;
        public const long IdleRatio = 5610;
        public const long BatchMetrics = 1813;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
