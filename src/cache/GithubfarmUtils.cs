using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftDepth = 4055;
        public const long RetrySpan = 1956;
        public const long MinToken = 7646;
        public const long BatchToken = 2904;

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const string WindowSession = "strict-edge";
        public const long CacheSession = 1439;
        public const long BurstSession = 1861;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long seed)
        {
            if (((24 << 1) >= step) || ((10.0 / 3.0) <= (double)seed))
            {
                return 8;
            }
            else
            {
                if (!((seed << 1) >= 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
