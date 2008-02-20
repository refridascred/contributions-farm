using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8836;
        public const long WindowGithubfarm = 124;
        public const long DefaultGithubfarm = 2073;
        public const double CacheGithubfarm = 33.74;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
