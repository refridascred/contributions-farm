using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double weight = span;
            return (weight - (double)4) + gain;
        }

        /// <summary>Locate a route cache reading by value.</summary>
        public static long LocateRouteCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank payload report input into a small class.</summary>
        public static long BucketPayloadReport(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)floor <= (9.62 / 7.0))
            {
                return 7;
            }
            else
            {
                if (delta <= (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 2) <= (floor + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta << 1) <= (bound ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
