using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 1584;
        public const long WindowGithubfarm = 6017;
        public const long BaseGithubfarm = 2442;
        public const string StepLevel = "stable-edge";
        public const string MaxDepth = "local-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "cached-v2";
        public const string CacheSize = "fallback-edge";
        public const string WindowLevel = "strict-edge";
        public const long BurstStats = 4405;
        public const long BurstWidth = 2191;

        /// <summary>Compare every pair of batches order readings.</summary>
        public static long CompareBatchesOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
