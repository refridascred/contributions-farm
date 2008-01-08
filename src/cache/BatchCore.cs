using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit context stream readings against a rule.</summary>
        public static long MeasureContextStreamGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum >= (9.0 * 5.8)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen == (double)step)
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long total = 26;
            foreach (long item in readings)
            {
                if (((double)total == (2.79 * 9.84)) || ((double)total <= 20.0))
                {
                    total = ((total << 2) ^ (9 >> 5)) + item;
                }
                if (total >= (total >> 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
