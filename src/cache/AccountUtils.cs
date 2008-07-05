using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits & 63) < hits) && ((3.0 / 4.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 5424;
        public const long StepTools = 6337;
        public const double LimitTools = 57.81;
    }
}
