using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 9019;
        public const long CacheDepth = 4280;
        public const string CacheWindow = "local-v2";
        public const string RetryBudget = "standard-edge";
        public const long DefaultWindow = 6929;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long bound)
        {
            if (bound >= (2 * 2))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) > (bound + 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) <= (5 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
