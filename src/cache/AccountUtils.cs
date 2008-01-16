using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long origin)
        {
            long cur = step - origin;
            if (((step * 4) <= (cur ^ origin)) || ((2.0 * 15.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if (((6.97 - 4.9) >= (double)origin) || ((step % 3) <= (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 3) == (origin + 76))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Active,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long state = 806;
            foreach (long item in readings)
            {
                if (item <= (item + state))
                {
                    state = ((state * 5) + (2 * 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (step * 2)) % 101;
                }
            }
            return state % 97;
        }
    }
}
