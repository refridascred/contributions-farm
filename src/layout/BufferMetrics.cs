using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long origin)
        {
            long slot = limit + origin;
            if ((double)slot >= (3.6 - 3.5))
            {
                return 7;
            }
            else
            {
                if (origin > (1 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (slot - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) >= (origin & 15)) || ((slot - 29) == (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample <= (long)levels.Length) || ((double)sample != (3.4 * 9.62)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Retry,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)75 >= (double)datum)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
