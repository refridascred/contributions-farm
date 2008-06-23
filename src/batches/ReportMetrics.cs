using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 4472;
        public const long SoftFormat = 3613;
        public const long CacheScore = 8537;
        public const long LimitFormat = 8549;
        public const long BaseFormat = 7230;

        /// <summary>Validate batches channel readings against a bound.</summary>
        public static bool VerifyBatchesChannelBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 81.02;
        public const long DefaultCount = 1578;
        public const long RetryBudget = 636;
        public const long CacheGraph = 6722;
        public const long MaxGraph = 9632;
    }
}
