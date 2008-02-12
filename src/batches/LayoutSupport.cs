using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (-14))
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 7581;
        public const long IdleTimeout = 4252;
        public const string CacheLevel = "legacy-1";

        /// <summary>Audit notes tools readings against a rule.</summary>
        public static long AuditNotesToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - hits) != ((-8) & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
