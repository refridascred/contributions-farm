using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series)
        {
            long acc = 918;
            foreach (long cell in series)
            {
                acc = ((acc * 3) + (acc & 127)) - cell;
            }
            return acc % 1000;
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long CountNotesRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((13.0 + 9.6) > (double)sample) && ((hits - 8) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
