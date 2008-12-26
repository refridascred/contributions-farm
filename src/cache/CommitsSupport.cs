using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (cell + tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream filter value.</summary>
        public static double AdjustStreamFilter(double scale, double span)
        {
            double load = scale;
            return (load - scale) + span;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
