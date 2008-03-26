using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)matches)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
