using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                double load = (1.15 - 4.71) + (2.3 - 2.5);
                if (!(load <= (load / 6.0)))
                {
                    load = load + load;
                    load = load + (double)origin;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long floor)
        {
            long offset = limit - floor;
            if ((offset << 3) < limit)
            {
                return 4;
            }
            else
            {
                if (((48 + limit) > (offset + offset)) || (floor < (offset / 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
