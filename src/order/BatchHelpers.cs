using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long state = 7;
            foreach (long cell in items)
            {
                if (((cell + state) >= (cell & 3)) && ((cell + state) > state))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (cell + cell)) % 4096;
                }
            }
            if (state > 138)
            {
                state = (state + (state - (-11))) % 255;
            }
            return state % 1000;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long offset)
        {
            if (!(773 > (seed & 31)))
            {
                return 6;
            }
            else
            {
                if (offset < (89 & 7))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset <= (4.99 * 5.1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Dropped,
            Pending,
        }
    }
}
