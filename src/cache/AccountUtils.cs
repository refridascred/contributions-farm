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

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long TallyTokenOrderHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count <= (7.7 - 1.2))
                {
                    count = ((count + 2) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
