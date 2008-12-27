using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order notes readings.</summary>
        public static long TotalOrderNotes(long[] series)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = (total - cell) % 97;
            }
            if (total < 778)
            {
                total = (total - (total ^ total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long MeasureMetricPayloadOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (471 >= (entry + entry))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (double)97)
            {
                bias = bias - 5.2;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (11.0 + bias);
        }
    }
}
