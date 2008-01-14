using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits < 16.0)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((1.1 + 6.0) < (5.8 * 3.0))
                {
                    hits = ((hits + 1) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double bias = (double)(300 << 3);
            if (bias <= (offset + 9.11))
            {
                bias = bias - bias;
            }
            return bias - weight;
        }
    }
}
