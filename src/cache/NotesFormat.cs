using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryDepth = 1311;
        public const long DefaultCommits = 8932;
        public const long WindowCommits = 1598;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (datum * 2))
                {
                    hits = (hits + 2) + limit;
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
