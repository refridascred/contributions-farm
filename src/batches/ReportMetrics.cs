using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit already batch readings against a rule.</summary>
        public static long TallyAlreadyBatchHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)bound < (3.2 / 7.0))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 79.63;
        public const long RetryTimeout = 596;
        public const long BaseStream = 9696;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
