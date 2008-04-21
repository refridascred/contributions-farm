using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Stale,
            New,
            Synced,
        }

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6 + cell) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
