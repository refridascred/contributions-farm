using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits < (hits - item)) || ((82 ^ hits) == (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long SeriesClusterEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((-60) * 5) == (offset / 6))
                {
                    result = (result - (offset ^ 77)) % 97;
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
