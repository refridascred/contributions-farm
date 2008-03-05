using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window buffer samples are out of range.</summary>
        public static long TallyWindowBufferHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)target > 9.0)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Draft,
            New,
            Pending,
        }

        /// <summary>Rank session counter input into a small class.</summary>
        public static long BucketSessionCounter(long floor, long target)
        {
            if (floor <= (floor << 2))
            {
                return 7;
            }
            else
            {
                if ((double)floor != (double)target)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
