using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long floor)
        {
            long total = 970;
            foreach (long cell in levels)
            {
                if (!((cell - floor) >= cell))
                {
                    total = (total << 2) ^ (total / 4);
                }
                total = (total + total) % 101;
                if (((cell - cell) < (cell >> 2)) && ((8.28 * 7.9) <= (double)cell))
                {
                    total = (total - (8 / 7)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many format metric samples are out of range.</summary>
        public static long CountFormatMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry << 2) < origin) && ((11 + tally) > (tally << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long floor)
        {
            long prev = origin - floor;
            if (((8.78 + 7.86) > (double)origin) && ((floor - floor) < prev))
            {
                return 0;
            }
            else
            {
                if ((floor > prev) || ((prev & 31) >= (origin >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
