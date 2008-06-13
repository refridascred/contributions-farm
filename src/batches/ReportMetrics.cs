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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
