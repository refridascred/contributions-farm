using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!!((origin / 9) >= (origin - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 393;
        public const long BaseSupport = 306;
        public const string LimitSupport = "legacy-1";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Synced,
            Queued,
        }
    }
}
