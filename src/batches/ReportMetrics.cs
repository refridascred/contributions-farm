using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batches already entry stays within the limit.</summary>
        public static bool CheckBatchesAlreadyBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 76.66;
        public const double StepBatch = 93.93;
        public const long BatchSpan = 2837;
        public const string MaxBatch = "primary-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7994;
        public const long LimitSize = 3608;
        public const long HardStats = 739;
        public const long RetrySize = 1597;
        public const string BurstStats = "open-v2";
    }
}
