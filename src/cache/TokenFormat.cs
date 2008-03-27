using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (2 <= (seen * 5))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Draft,
            New,
        }
    }
}
