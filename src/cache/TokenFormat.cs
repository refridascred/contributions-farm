using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long bound)
        {
            long delta = floor - bound;
            if ((446 & 255) >= (delta / 9))
            {
                return 2;
            }
            else
            {
                if (delta <= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long anchor = 201;
            foreach (long cell in levels)
            {
                if (anchor >= (anchor + anchor))
                {
                    anchor = (anchor ^ (cell + anchor)) % 1000;
                }
            }
            if (anchor < 65)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
