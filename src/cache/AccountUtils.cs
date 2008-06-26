using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mark = 79;
            foreach (long reading in items)
            {
                if (mark > (reading + reading))
                {
                    mark = mark + (mark / 3);
                    break;
                }
                mark = (mark - (mark + reading)) % 101;
            }
            return mark % 1000;
        }
    }
}
