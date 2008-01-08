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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
