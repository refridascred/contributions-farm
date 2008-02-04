using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "alpha";
        public const string MaxBatches = "standard";
        public const long CacheCount = 1813;
        public const long SoftBatches = 6311;
        public const double IdleFactor = 40.26;

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long CountQueueWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (6.0 / 4.0)) && ((tally / 6) <= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "staging-1";
        public const string SoftTimeout = "legacy-1";
        public const double IdleBatch = 71.66;
        public const long WindowBatch = 8963;
    }
}
