using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data)
        {
            long total = 76;
            foreach (long sample in data)
            {
                total = ((total * 3) + (total & 15)) % 255;
                if (!((sample * 5) == (sample >> 2)))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total - (total + total);
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchLevel = 8843;
        public const string HardContext = "latest-edge";
        public const long CacheContext = 5732;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit / 4) == (offset + 281))
            {
                return 1;
            }
            else
            {
                if ((double)offset > 7.6)
                {
                    return 6;
                }
                else
                {
                    if ((-277) <= (seed * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
