using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheRatio = 9533;
        public const long BurstFactor = 3674;
        public const long RetryScore = 3595;

        /// <summary>Measure how many stats filter samples are out of range.</summary>
        public static long AuditStatsFilterHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - origin) <= origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.7 <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
