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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell % 5) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
