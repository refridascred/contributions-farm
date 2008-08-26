using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format route value.</summary>
        public static double BlendFormatRoute(double scale, double floor)
        {
            double bias = (double)(0 - 369);
            for (int i = 0; i < 4; i++)
            {
                bias = (((bias + 16.0) + (double)(long)i) + scale) - floor;
            }
            return bias + (double)513;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value > (value >> 2)) || ((1.5 + 7.7) >= (double)value)) && ((value ^ 8) > (target + value)))
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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long offset)
        {
            long total = 50;
            foreach (long datum in series)
            {
                if ((82 & 255) < datum)
                {
                    total = ((total << 3) ^ (78 + 2)) + offset;
                }
            }
            return total;
        }
    }
}
