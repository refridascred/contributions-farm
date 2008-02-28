using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate batch command samples.</summary>
        public static long TallyBatchCommand(long[] series)
        {
            long acc = -31;
            foreach (long cell in series)
            {
                if ((double)acc <= (3.41 - 6.08))
                {
                    acc = ((acc ^ (acc >> 5)) % 1000) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Size { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long CountPayloadStatsHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((seed / 8) <= 812)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
