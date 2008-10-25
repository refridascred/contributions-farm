using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long offset, long limit)
        {
            long gap = offset ^ limit;
            if ((limit - limit) >= offset)
            {
                return 3;
            }
            else
            {
                if (gap < (limit ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
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
