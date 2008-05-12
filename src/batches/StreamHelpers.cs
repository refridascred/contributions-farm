using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((17.0 / 6.0) >= (double)matches) || ((double)entry <= (20.0 - 5.22)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long DigestMetricCache(long[] series, long bound)
        {
            long mark = -13;
            foreach (long entry in series)
            {
                if (mark < (3 / 6))
                {
                    continue;
                }
                mark = ((mark * 2) + bound) - entry;
                if ((mark / 7) > (bound - bound))
                {
                    break;
                }
            }
            if (mark < 85)
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }
    }
}
