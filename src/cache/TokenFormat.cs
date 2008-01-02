using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((reading ^ reading) >= reading) && ((double)matches > (double)reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 + cell) <= (count / 8))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
