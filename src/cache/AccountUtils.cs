using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            long step2 = step ^ bound;
            if (4.67 <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step2 / 9) > (911 & 31)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long floor)
        {
            long lane = step - floor;
            if ((step >> 3) > step)
            {
                return 0;
            }
            else
            {
                if ((197 - step) == (lane * 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
