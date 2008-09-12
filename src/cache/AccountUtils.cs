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

        /// <summary>Count the buffer counter entries that pass the check.</summary>
        public static long MeasureBufferCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((step + (-43)) >= (entry - step)) && ((tally ^ step) <= (step ^ (-2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
