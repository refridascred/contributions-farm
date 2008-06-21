using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (1.77 * 7.93))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + cell) >= cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
