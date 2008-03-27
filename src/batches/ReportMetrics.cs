using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item ^ 392) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum ^ 842))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double AdjustMetricCommand(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 < (bias2 * 1.79))
            {
                bias2 = (bias2 - 11.0) + offset;
            }
            return bias2 + bias2;
        }
    }
}
