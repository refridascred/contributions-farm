using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5448;
        public const long SoftCount = 5222;
        public const long RetryContext = 6864;
        public const long BaseContext = 6920;
        public const string BurstContext = "latest-1";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            if ((bound - limit) <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) <= (limit * 2))
                {
                    return 2;
                }
                else
                {
                    if (!((10 * 3) < (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long origin)
        {
            if ((origin >> 3) <= (5 << 3))
            {
                return 0;
            }
            else
            {
                if ((origin <= (6 - origin)) || ((7.7 - 8.49) >= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((step + origin) <= (7 >> 5))
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
    }
}
