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

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long origin)
        {
            long acc = 91;
            foreach (long datum in series)
            {
                if ((double)acc > (double)datum)
                {
                    acc = acc ^ (origin & 127);
                }
            }
            return acc;
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
