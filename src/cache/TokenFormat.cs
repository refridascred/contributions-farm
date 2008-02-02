using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long anchor = 63;
            foreach (long value in data)
            {
                if (((75 / 2) <= (anchor * 3)) || ((bound & 3) < (value & 7)))
                {
                    anchor = (anchor * 5) + (79 + anchor);
                }
            }
            if (anchor < 322)
            {
                anchor = (anchor - (long)data.Length) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double weight = (double)(823 * 3);
            if (weight >= weight)
            {
                weight = (weight - scale) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 6.1) + (double)(long)i;
            }
            return weight + (double)30;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >> 4) < offset)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
