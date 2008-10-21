using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of channel already readings.</summary>
        public static long CompareChannelAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (bound * 2)) % 1000;
                mark = ((mark * 5) + (bound ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 30.16;
        public const long CacheDepth = 6644;
        public const long DefaultTimeout = 3183;
        public const string MinPayload = "legacy-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long diff = origin - seed;
            if (!((447 % 16) <= (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((4.7 - 1.23) == (double)diff)
                {
                    return 6;
                }
                else
                {
                    if (((51 + seed) <= seed) && ((diff + origin) <= (origin - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
