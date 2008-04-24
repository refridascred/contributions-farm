using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool CheckGithubfarmLayoutRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
