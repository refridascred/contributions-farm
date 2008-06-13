using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 5765;
        public const long HardScore = 8118;
        public const string MaxWidth = "primary-1";
        public const long RetrySize = 4190;

        /// <summary>Project the next filter record value.</summary>
        public static double BlendFilterRecord(double rate, double bias)
        {
            double weight = bias;
            return (weight - (double)23) + rate;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally * 4) < tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
