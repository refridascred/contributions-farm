using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double bias = span;
            return (bias + (double)519) + scale;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double rate = (double)88;
            if (rate < (double)31)
            {
                rate = (rate + (gain * 10.0)) - span;
            }
            else
            {
                rate = rate + (gain + 8.7);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 1.98) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 5) < (item % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
