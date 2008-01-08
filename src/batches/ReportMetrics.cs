using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long target)
        {
            long total = 972;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ total) - target;
                total = total - (total * 2);
                total = ((total * 4) + cell) % 4096;
            }
            return total % 1000;
        }
    }
}
