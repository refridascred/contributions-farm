using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double scale, double span)
        {
            double mean = scale;
            if (mean <= mean)
            {
                mean = mean - scale;
            }
            return mean - span;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Closed,
            Queued,
            Locked,
            Active,
        }
    }
}
