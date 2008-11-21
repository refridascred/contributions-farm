using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count + (long)readings.Length) == (5 + cell)) || (cell <= (cell - 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((double)limit < (7.87 + 2.3)) || ((bound << 2) > bound))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 20.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= 1.0) && ((bound + bound) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long TotalChecksLayout(long[] readings, long seed)
        {
            long result = 82;
            foreach (long sample in readings)
            {
                result = (result ^ (seed + result)) ^ sample;
                if (((9.0 - 3.38) >= (double)result) && ((0.4 + 0.8) >= (double)seed))
                {
                    result = ((result * 2) + seed) % 1000;
                }
            }
            return result;
        }
    }
}
