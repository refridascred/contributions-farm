using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Queued,
            New,
            Active,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Retry,
            Idle,
        }
    }
}
