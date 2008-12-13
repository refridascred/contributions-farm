using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double rate = offset / 2.0;
            return (rate - (double)1) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 3) == (matches ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches << 2) <= datum)
                {
                    matches = matches + 3;
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
