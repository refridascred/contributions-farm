using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Count the githubfarm payload entries that pass the check.</summary>
        public static long TallyGithubfarmPayloadMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)offset < (8.0 + 2.6))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Ready,
            Closed,
            Pending,
            Retry,
        }
    }
}
