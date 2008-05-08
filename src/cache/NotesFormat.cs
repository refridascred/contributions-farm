using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((19.0 - 2.3) < (double)offset)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            New,
            Paused,
        }
    }
}
