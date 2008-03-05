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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long step)
        {
            long next = origin + step;
            if (!((double)next > (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (2.57 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (!((80 + next) >= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
