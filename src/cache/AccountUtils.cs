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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (6.9 + 19.0))
                {
                    count = ((count + 3) ^ value) - seed;
                }
            }
            return count;
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
