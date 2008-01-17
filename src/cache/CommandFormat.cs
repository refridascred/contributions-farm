using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - entry) <= (seen & 3))
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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Paused,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((6.67 + 2.9) > (double)tally) && ((double)tally == (double)650)))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
