using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = result + ((long)i + result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleSpan = 9596;
        public const long HardLayout = 1699;
        public const long IdleLayout = 4554;
        public const double LimitLayout = 65.29;
        public const string WindowFactor = "local-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 8882;
        public const long StepGithubfarm = 9995;
        public const long CacheBudget = 828;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
