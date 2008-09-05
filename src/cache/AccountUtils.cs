using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches buffer entries that pass the check.</summary>
        public static long AuditBatchesBufferMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value - hits) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
