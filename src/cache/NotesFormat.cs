using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long MeasureAccountMetricMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (entry ^ origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 3989;
        public const string SoftCache = "latest-v2";
        public const long SoftSpan = 6071;
    }
}
