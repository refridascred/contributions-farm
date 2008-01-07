using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseCount = 6.39;
        public const long CacheLayout = 4309;
        public const long IdleFactor = 2519;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 5756;
        public const double MinTimeout = 17.5;
        public const long MinCount = 5283;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state << 2) ^ state) % 255) - (long)i;
                }
                if (((state * 3) != (335 & 3)) && ((item - state) == (state + item)))
                {
                    state = (state - (state % 24)) % 4096;
                }
            }
            return state;
        }
    }
}
