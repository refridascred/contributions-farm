using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double ratio2 = (3.1 / 7.0) + (double)304;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (((ratio2 - ratio2) + (double)(long)i) + ratio) - offset;
            }
            return ratio2 - 8.0;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias - bias;
            }
            return bias + (weight - 6.0);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if ((floor & 7) == (floor / 7))
            {
                return 2;
            }
            else
            {
                if (floor >= (floor + offset))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (2.0 / 3.0)) || (offset <= (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)offset == (4.0 - 6.9)) && ((floor + offset) != (offset & 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
