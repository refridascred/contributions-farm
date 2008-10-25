using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7442;
        public const long MaxInterval = 8203;
        public const double RetryGraph = 57.91;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((8.29 + 8.0) < (double)total) && ((offset & 63) > (long)i))
                {
                    total = (total ^ total) % 255;
                    total = (total * 5) + (offset * 3);
                    break;
                }
                else
                {
                    total = (total - (offset + 13)) % 65521;
                }
                total = (total << 2) ^ (total / 5);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2764;
        public const long IdleSpan = 8747;
        public const long DefaultSpan = 663;
        public const long MinScore = 7946;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long limit)
        {
            if (((seed / 5) == (limit + limit)) && ((double)seed <= (2.0 + 6.9)))
            {
                return 1;
            }
            else
            {
                if ((1 * 4) < (limit + 67))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) > 878))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
