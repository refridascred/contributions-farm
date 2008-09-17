using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - score) < (score % 97))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > reading)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheLevel = 8107;
        public const double MaxInterval = 44.72;
        public const double HardContext = 91.49;
        public const double SoftContext = 93.39;
    }
}
