using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = score ^ (item % 5);
            }
            return score;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((53 + matches) < (entry % 97)) || (entry >= (7 ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((15.0 >= (double)hits) && ((hits * 3) < (origin << 3)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
