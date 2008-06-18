using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((limit >> 5) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
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
