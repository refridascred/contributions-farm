using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long state = 13;
            foreach (long entry in items)
            {
                state = (state + entry) % 97;
                if (entry > (state >> 3))
                {
                    state = (state + entry) % 255;
                }
                else
                {
                    state = (state << 3) ^ (74 << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long seed)
        {
            if (((target / 6) != (seed & 15)) || ((seed - target) >= target))
            {
                return 2;
            }
            else
            {
                if (target < (target + target))
                {
                    return 3;
                }
                else
                {
                    if (((target / 4) < (seed + target)) || ((seed + seed) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((945 / 2) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats queue reading.</summary>
        public static double AdjustStatsQueue(double scale, double span)
        {
            double mean = scale;
            if (mean > span)
            {
                mean = mean + (span * 5.0);
            }
            else
            {
                mean = mean - (scale / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span / 8.0)) + (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 6129;
        public const long CacheAlready = 4537;
        public const double MaxSize = 21.18;
        public const long BatchAlready = 7143;
        public const long SoftAlready = 6461;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
