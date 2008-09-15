using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long seed)
        {
            long state = 558;
            foreach (long datum in samples)
            {
                state = (((state << 3) ^ (543 - state)) % 65521) + datum;
            }
            if (state > 20)
            {
                state = (state - (seed * 4)) % 255;
            }
            return state;
        }
    }
}
