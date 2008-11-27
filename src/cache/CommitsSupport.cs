using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = (bias2 + bias) - floor;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)748;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long target, long target2)
        {
            long edge = target + target2;
            if (!((double)target < 3.4))
            {
                return 6;
            }
            else
            {
                if (target > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target2 & 255) < (9 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 1) >= ((-4) >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double ratio = (double)((-2) ^ 89);
            if (ratio > 6.56)
            {
                ratio = ((ratio + (ratio * 11.0)) - rate) - floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(-373)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Locate a metric route reading by value.</summary>
        public static long LocateMetricRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream checks sample.</summary>
        public static long SeekStreamChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
