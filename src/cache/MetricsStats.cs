using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 5308;
        public const double MaxScore = 40.96;
        public const long LimitReport = 9742;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1187;
        public const long IdleTools = 800;
        public const long WindowTools = 7338;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)score < (double)seed) && ((8.49 - 5.27) < (double)seed))
                {
                    score = ((score << 2) ^ seed) % 65521;
                    score = (score << 3) ^ (2 << 2);
                }
                if (!((1.57 - 2.1) <= (double)(long)i))
                {
                    score = score + (score - seed);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
