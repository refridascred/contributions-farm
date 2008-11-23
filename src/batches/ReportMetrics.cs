using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1890;
        public const long BurstCounter = 5030;
        public const double BurstSpan = 87.93;
        public const long StepCounter = 8193;
        public const long MaxCounter = 4015;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            New,
            Done,
            Draft,
        }
    }
}
