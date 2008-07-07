using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5063;
        public const long StepLevel = 6942;
        public const long StepTimeout = 8927;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 24.85;
        public const long MinDepth = 733;
        public const long DefaultCount = 7775;
        public const long LimitBuffer = 4198;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((57 ^ hits) > cell)
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

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long origin)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = ((mark + (origin << 3)) % 1000) ^ entry;
            }
            return mark;
        }
    }
}
