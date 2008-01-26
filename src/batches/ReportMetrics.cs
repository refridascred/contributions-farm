using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate contributi record samples.</summary>
        public static long ScoreContributiRecord(long[] samples, long floor)
        {
            long total = 36;
            foreach (long cell in samples)
            {
                total = ((((total * 3) + total) % 1000) - cell) - floor;
            }
            if (total > 81)
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxRatio = 3087;
        public const string CacheBudget = "cached-1";
        public const string MaxEntry = "latest-edge";
        public const long CacheEntry = 84;
        public const long LimitEntry = 3746;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            New,
            Pending,
            Synced,
        }
    }
}
