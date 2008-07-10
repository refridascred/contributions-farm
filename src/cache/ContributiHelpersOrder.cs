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

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardCount = 94.5;
        public const double BatchWidth = 93.76;
        public const long CacheSchema = 6801;
        public const long RetryInterval = 5781;
    }
}
