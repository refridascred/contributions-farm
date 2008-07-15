using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double scale = bias;
            return scale - (span / 3.0);
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long prev = bound + origin;
            if (((-74) - bound) > bound)
            {
                return 7;
            }
            else
            {
                if (6.36 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((prev * 4) <= (55 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev & 127) <= (bound + 846))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (((floor ^ origin) >= ((-74) + floor)) || (9 < (floor % 3)))
            {
                return 3;
            }
            else
            {
                if (14 < (origin ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (66 <= (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 7;
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
}
