using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((9.81 + 9.97) <= (double)target)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of window editor entries.</summary>
        public static long CombineWindowEditor(long[] series, long target)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                if (((2.7 + 6.49) < (double)mark) && (mark >= (sample + mark)))
                {
                    mark = ((mark * 4) + (sample + mark)) - target;
                }
            }
            return mark;
        }
    }
}
