using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = 2.0 * 2.09;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((offset * 4) >= (offset / 2))
            {
                return 5;
            }
            else
            {
                if ((floor & 15) <= slot)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (86 > (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
