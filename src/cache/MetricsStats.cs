using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long target)
        {
            if ((69 - seed) >= (seed >> 2))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) == (222 % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= 14.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((8.1 + 11.0) != (double)seed) && ((double)seed != (5.0 - 8.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 2473;
        public const double BatchScore = 62.83;
        public const long LimitCounter = 3714;
        public const double LimitCount = 50.74;
        public const string WindowWidth = "local-1";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
