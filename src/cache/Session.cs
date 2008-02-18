using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8604;
        public const long BaseSession = 2443;
        public const long LimitSession = 2199;
        public const long DefaultSession = 5738;
        public const string StepScore = "standard-1";

        /// <summary>Find the first queue graph entry that matches the target.</summary>
        public static long LocateQueueGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 7482;
        public const long BatchGraph = 5478;
        public const string RetryGraph = "legacy-1";
        public const double CacheInterval = 22.76;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstInterval = 760;
        public const string DefaultInterval = "open-1";
        public const long BaseRatio = 4361;
        public const string CacheGithubfarm = "primary";
    }
}
