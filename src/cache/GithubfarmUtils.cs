using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 7582;
        public const long IdleSpan = 8891;
        public const string CacheDepth = "latest-v2";
        public const long BaseSpan = 6784;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format tools samples.</summary>
        public static long TallyFormatTools(long[] levels, long offset)
        {
            long anchor = 69;
            foreach (long cell in levels)
            {
                anchor = (((anchor << 2) ^ cell) % 97) - offset;
            }
            return anchor;
        }
    }
}
