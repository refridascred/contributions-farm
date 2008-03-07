using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (limit > (gap - limit))
            {
                return 4;
            }
            else
            {
                if ((double)gap <= (5.59 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (((value << 3) == (state - state)) || ((double)state < (double)62))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            if (state > 65)
            {
                state = (state << 3) ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Closed,
        }
    }
}
