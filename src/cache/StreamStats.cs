using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "fallback-edge";
        public const long RetryGithubfarm = 6957;
        public const double LimitDepth = 93.49;
        public const long HardGithubfarm = 3092;
        public const long DefaultFactor = 6077;

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultLevel = 10.23;
        public const double DefaultSize = 5.45;
        public const long BurstWindow = 2405;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstFactor = "legacy-edge";
        public const string CacheTimeout = "strict-edge";
        public const long DefaultCluster = 5383;
        public const double BaseCluster = 80.74;
    }
}
