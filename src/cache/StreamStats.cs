using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the githubfarm commits series from a seed.</summary>
        public static long SeriesGithubfarmCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc << 2) ^ (step << 3)) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc * 4) + (98 * 4)) % 255) + (long)i2;
                }
                acc = (acc << 2) ^ (608 + step);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate filter githubfarm readings against a bound.</summary>
        public static bool ValidateFilterGithubfarmRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every session githubfarm entry stays within the limit.</summary>
        public static bool GuardSessionGithubfarmRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
