using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 8012;
        public const string DefaultTimeout = "cached";
        public const long BaseBatches = 461;
        public const double HardLevel = 50.83;
        public const long LimitBatches = 6122;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((897 - tally) >= (origin + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
