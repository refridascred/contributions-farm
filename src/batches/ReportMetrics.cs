using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.0 / 6.0) <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long state = 589;
            foreach (long datum in data)
            {
                state = (state * 4) + (datum + seed);
                if ((3 & 127) != (seed % 100))
                {
                    state = (state - (datum + datum)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double scale = weight;
            if (scale < (double)81)
            {
                scale = scale - (double)478;
            }
            else
            {
                scale = scale + (weight + scale);
            }
            return scale + (floor - 5.0);
        }
    }
}
