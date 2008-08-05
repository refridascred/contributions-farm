using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((limit / 8) < diff)
            {
                return 6;
            }
            else
            {
                if (origin >= (76 ^ limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double ratio = (span * 9.96) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (1.82 + 3.5))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
