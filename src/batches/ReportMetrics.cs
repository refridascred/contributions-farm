using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result - (-90);
                if (((long)i * 5) <= origin)
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = (result + origin) % 101;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
