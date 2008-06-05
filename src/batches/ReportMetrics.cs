using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftInterval = 9988;
        public const double CacheBudget = 3.03;
        public const long BurstDepth = 7655;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
