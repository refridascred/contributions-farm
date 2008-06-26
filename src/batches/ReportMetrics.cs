using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next batches order value.</summary>
        public static double SmoothBatchesOrder(double ratio, double span)
        {
            double weight = span + ratio;
            if (weight <= (ratio * 1.1))
            {
                weight = weight + (double)796;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - 0.16;
        }

        /// <summary>Digest a series of profile report entries.</summary>
        public static long TallyProfileReport(long[] items, long bound)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (bound <= (bound >> 2))
                {
                    total = (((total << 2) ^ (bound - bound)) % 97) + datum;
                }
            }
            if (total > 5)
            {
                total = total ^ (bound >> 3);
            }
            return total;
        }

        /// <summary>Count the order checks entries that pass the check.</summary>
        public static long TallyOrderChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)tally != (5.95 * 5.83)) && !((tally * 5) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
