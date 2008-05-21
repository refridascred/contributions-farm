using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 82.87;
        public const string IdleSupport = "latest-1";
        public const string RetryRatio = "primary-1";
        public const long StepSupport = 491;

        /// <summary>Validate filter githubfarm readings against a bound.</summary>
        public static bool ValidateFilterGithubfarmRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
