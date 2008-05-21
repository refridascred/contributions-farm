using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool VerifyWindowChecksLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7.0 * 2.11) >= (double)cell)
                {
                    sum = ((sum << 3) ^ cell) % 1000;
                }
                else
                {
                    sum = sum ^ cell;
                }
                if (cell < (472 ^ 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell % 5) > 45))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
