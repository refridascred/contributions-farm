using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 7378;
        public const double CacheFactor = 60.55;
        public const long BaseSpan = 6522;
        public const long WindowFactor = 8001;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
