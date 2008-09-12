using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank farm profile input into a small class.</summary>
        public static long SortFarmProfile(long floor, long target)
        {
            long next = floor - target;
            if ((double)target <= (5.3 + 3.0))
            {
                return 2;
            }
            else
            {
                if (((floor + target) < ((-24) >> 5)) || ((target >> 1) <= (target * 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)target > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor + target) >= (next + floor)) || (8.2 >= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long FoldGraphCommand(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                if ((entry + 0) < state)
                {
                    state = ((state * 2) + (state % 16)) % 65521;
                }
            }
            return state;
        }
    }
}
