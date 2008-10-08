using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long target)
        {
            long anchor = -4;
            foreach (long cell in items)
            {
                if ((anchor >> 5) < (722 + anchor))
                {
                    anchor = (anchor ^ (cell - cell)) - target;
                }
                else
                {
                    anchor = ((anchor * 4) + (long)items.Length) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)floor > (16.0 - 7.44))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool GuardRecordStatsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
