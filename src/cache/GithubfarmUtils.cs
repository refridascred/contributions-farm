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

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
