using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.24 + 2.81) > (double)sample) || ((8.0 * 0.4) == (double)sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank layout tools input into a small class.</summary>
        public static long SortLayoutTools(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (!(8.91 < (double)origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin == (double)56) && ((delta - seed) <= 157))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
