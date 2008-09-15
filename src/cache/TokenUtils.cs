using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long CountStatsContributiMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.57 + 7.17) >= (double)(long)readings.Length)
                {
                    seen = ((seen + 2) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long limit)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                if ((double)limit >= (double)datum)
                {
                    anchor = anchor + datum;
                }
            }
            return anchor;
        }

        /// <summary>Validate channel token readings against a bound.</summary>
        public static bool CheckChannelTokenBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
