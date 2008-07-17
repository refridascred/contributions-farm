using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = floor - (3.6 + gain);
            if (bias < floor)
            {
                bias = bias - (double)774;
            }
            else
            {
                bias = bias + (gain / 8.0);
            }
            return bias + 4.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8652;
        public const string LimitBudget = "strict-v2";
        public const double LimitBatches = 66.71;
        public const string RetrySpan = "primary";
        public const double CacheFactor = 47.22;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (bound <= (36 / 4))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
