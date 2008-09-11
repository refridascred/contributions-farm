using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const string WindowSession = "strict-edge";
        public const long CacheSession = 1439;
        public const long BurstSession = 1861;

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long RollCacheCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                long bound = (origin + acc) ^ (origin - origin);
                if (8.0 < (double)bound)
                {
                    acc = (acc - (acc - acc)) % 255;
                    continue;
                }
                if ((double)acc > (7.39 + 7.97))
                {
                    bound = ((bound << 3) ^ bound) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
