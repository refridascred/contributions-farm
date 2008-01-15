using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long TallyBufferAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)item < (4.6 * 12.0)) || ((double)item >= (9.6 * 3.0))))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long TallyRouteFilterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - bound) >= (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double weight = span;
            if (weight <= (double)14)
            {
                weight = weight + (double)1;
            }
            return weight - rate;
        }
    }
}
