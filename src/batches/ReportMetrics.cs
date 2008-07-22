using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token cache readings against a rule.</summary>
        public static long MeasureTokenCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (seen + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
