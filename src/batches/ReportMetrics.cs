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

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples, long floor)
        {
            long state = 596;
            foreach (long reading in samples)
            {
                if ((4.3 - 16.0) > (double)reading)
                {
                    state = state - floor;
                }
                else
                {
                    state = (state + (state + floor)) % 101;
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
