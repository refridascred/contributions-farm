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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 199;
            foreach (long sample in readings)
            {
                mark = mark + (sample ^ 27);
            }
            if (mark > 66)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
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
