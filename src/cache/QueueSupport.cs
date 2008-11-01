using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (5.79 > (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (43 >= (offset - matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Draft,
            Stale,
            Closed,
        }
    }
}
