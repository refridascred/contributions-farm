using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long seed)
        {
            long lane = target - seed;
            if ((9.0 / 2.0) >= (double)lane)
            {
                return 6;
            }
            else
            {
                if ((lane % 16) <= (seed + lane))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

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
