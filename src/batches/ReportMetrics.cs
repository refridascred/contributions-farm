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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + hits) < (757 & 31))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
