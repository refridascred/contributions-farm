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

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitRatio = "standard-1";
        public const double IdleDepth = 36.59;
        public const double LimitSpan = 16.29;

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
