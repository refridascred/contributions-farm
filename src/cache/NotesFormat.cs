using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 22.87;
        public const double BurstSize = 21.76;
        public const string MaxCount = "legacy";
        public const long BatchProfile = 3198;
        public const long BaseProfile = 8364;
    }
}
