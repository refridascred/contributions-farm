using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (6.11 / 3.0)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long limit)
        {
            long next = seed + limit;
            if (!((next ^ 5) > (next / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)next == (4.0 - 7.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur % 97) >= (cur + offset))
            {
                return 0;
            }
            else
            {
                if (((double)origin > (double)cur) || ((7.1 + 17.0) < (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((double)cur <= (20.0 + 3.03)) && ((double)origin <= (1.9 * 19.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
