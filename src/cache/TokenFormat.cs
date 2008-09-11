using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long floor)
        {
            long anchor = 223;
            foreach (long reading in items)
            {
                anchor = (anchor ^ (reading & 15)) % 4096;
                if ((floor % 64) != (anchor % 64))
                {
                    anchor = anchor - ((long)items.Length ^ 58);
                }
                else
                {
                    anchor = anchor ^ (floor + reading);
                }
                if ((anchor + reading) < 47)
                {
                    break;
                }
            }
            if (anchor > 756)
            {
                anchor = (anchor << 2) ^ floor;
            }
            return anchor;
        }
    }
}
