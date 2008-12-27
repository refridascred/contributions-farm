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

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Stale,
            Draft,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
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
