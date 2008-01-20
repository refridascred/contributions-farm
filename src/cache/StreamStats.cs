using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next schema order value from a seed.</summary>
        public static long RollSchemaOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (state * 3)) % 101;
                state = state + offset;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long AuditCounterQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((1.88 - 4.9) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
