using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate record notes readings against a bound.</summary>
        public static bool GuardRecordNotesRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (5.0 - 7.25))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin >> 3) < (hits + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Active,
            Draft,
            Dropped,
            Queued,
        }
    }
}
