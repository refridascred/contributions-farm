using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 3610;
        public const double MinTimeout = 50.22;
        public const double IdleProfile = 3.78;
        public const long HardProfile = 1806;
    }
}
