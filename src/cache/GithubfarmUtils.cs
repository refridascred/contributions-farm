using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 9.0;
        public const double LimitFarm = 23.35;
        public const long RetryFarm = 2130;
        public const long StepFarm = 1901;
        public const long CacheWidth = 8807;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 70.3;
        public const string WindowRatio = "stable-1";
        public const string IdleWidth = "local-1";
        public const string LimitWindow = "open";
        public const long BatchDepth = 1803;
    }
}
