using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 2) >= ((long)series.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2212;
        public const long LimitSize = 4124;
        public const long BatchCache = 2248;
        public const string SoftCache = "staging-edge";

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits % 16) < (-18))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
