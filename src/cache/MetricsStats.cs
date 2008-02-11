using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Queued,
            Pending,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score + (score << 1)) ^ (long)i2;
                }
                score = ((score * 2) + (offset + score)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "alpha-v2";
        public const string CacheScore = "staging-1";
        public const long CacheStats = 803;
        public const string BurstStats = "staging";
        public const string MaxStats = "staging-edge";
    }
}
