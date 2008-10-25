using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
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

        /// <summary>Compare every pair of tools context readings.</summary>
        public static long PairToolsContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
