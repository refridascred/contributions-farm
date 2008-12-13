using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSize = 8513;
        public const long StepBatch = 3357;
        public const string WindowBatch = "legacy";
        public const long RetryBatch = 8745;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((origin / 9) > (origin >> 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Done,
            Pending,
            Queued,
            Active,
        }
    }
}
