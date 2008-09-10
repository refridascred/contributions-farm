using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double bias)
        {
            double weight = bias + bias;
            if (weight <= 5.0)
            {
                weight = (weight + (bias * 9.25)) + scale;
            }
            return weight + weight;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.51 + 6.0) > (double)matches)
                {
                    matches = ((matches + 2) ^ item) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
