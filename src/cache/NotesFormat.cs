using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 5) <= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen >= (double)(long)samples.Length) && (origin >= (cell + origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchTimeout = 3985;
        public const double WindowCommits = 91.02;
        public const long BurstCommits = 4723;
        public const string WindowInterval = "standard-edge";
    }
}
