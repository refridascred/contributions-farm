using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long sum = 48;
            foreach (long datum in series)
            {
                long step = ((long)series.Length + 14) * 2;
                if (target < 9)
                {
                    sum = sum + (step * 5);
                }
                sum = (sum * 2) + (sum + datum);
            }
            return sum % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.4 / 2.0) <= (double)floor)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
