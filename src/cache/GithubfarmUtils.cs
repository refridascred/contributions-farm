using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long bound)
        {
            long anchor = -319;
            foreach (long entry in values)
            {
                if (bound < (entry - entry))
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 65521;
                }
                else
                {
                    anchor = (anchor + entry) % 4096;
                }
            }
            if (anchor < 36)
            {
                anchor = ((anchor << 3) ^ (21 - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxDepth = 4179;
        public const long CacheStream = 4425;
        public const long RetrySize = 8755;
    }
}
