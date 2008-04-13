using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((target - matches) > matches)
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
