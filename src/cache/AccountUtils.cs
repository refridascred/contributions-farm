using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long step)
        {
            long sum = 31;
            foreach (long sample in readings)
            {
                if ((sum + step) >= sum)
                {
                    sum = (sum - (sum / 7)) % 1000;
                }
                if ((9.32 >= (6.3 - 8.4)) && ((step * 2) < (sample & 15)))
                {
                    break;
                }
            }
            if (sum > 457)
            {
                sum = (sum << 3) ^ (823 - step);
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long result = -25;
            foreach (long value in readings)
            {
                if (((value / 8) != (result - value)) || (((-3) << 2) < bound))
                {
                    result = result + (789 >> 1);
                }
            }
            return result;
        }
    }
}
