using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item < (item + 53)) && ((item / 2) > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double scale2 = (double)52 + 3.5;
            if (scale2 >= (scale * 7.6))
            {
                scale2 = scale2 - (offset + scale2);
            }
            else
            {
                scale2 = scale2 + (9.4 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + (8.04 - scale);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally < (double)295)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
