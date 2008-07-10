using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "standard-edge";
        public const long MaxGraph = 7658;
        public const long LimitGraph = 4803;
        public const long HardScore = 8660;
        public const string BurstTimeout = "staging-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardCount = 94.5;
        public const double BatchWidth = 93.76;
        public const long CacheSchema = 6801;
        public const long RetryInterval = 5781;
    }
}
