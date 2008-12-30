using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits / 4) >= value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((2.0 / 5.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 6142;
        public const long BatchAccount = 2580;
        public const long StepAccount = 1208;
        public const long RetryBudget = 3558;
        public const long BurstRatio = 6258;
    }
}
