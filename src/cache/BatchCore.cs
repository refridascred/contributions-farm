using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long MeasureGraphToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches & 255) == (25 + reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            New,
            Locked,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
