using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = (double)(494 + 3);
            if (gain < span)
            {
                gain = gain - (6.19 - 5.2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.7 - scale)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (matches % 64))
                {
                    matches = ((matches + 2) ^ cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long MeasureProfileCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) > (entry << 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
