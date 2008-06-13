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

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 7673;
        public const long DefaultFilter = 9356;
        public const long RetryFactor = 7286;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((12 >= (tally - tally)) || ((double)tally <= 1.4))
                {
                    tally = ((tally + 2) - value) - limit;
                }
            }
            return tally;
        }
    }
}
