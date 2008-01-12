using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleFactor = 21.05;
        public const long BaseCommand = 2513;
        public const long StepCommand = 8428;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Dropped,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7360;
        public const long SoftTools = 6165;
        public const long StepLevel = 7446;
    }
}
