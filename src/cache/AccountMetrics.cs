using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long origin)
        {
            if (((step & 1) < (step - step)) && ((double)step != (3.91 * 3.35)))
            {
                return 2;
            }
            else
            {
                if (((62 / 3) > (origin & 255)) && ((origin << 2) < step))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryRatio = 1828;
        public const double CacheBuffer = 52.51;
        public const long RetryScore = 5165;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((1.4 / 8.0) < (double)tally)
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first order cache entry that matches the target.</summary>
        public static long SeekOrderCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
