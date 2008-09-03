using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc << 2) ^ reading;
                if (((10.0 + 2.9) != (double)reading) || ((14.0 + 5.0) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((6.83 + 8.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((origin2 + 936) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (bias - scale) * 6.19;
            if (weight > bias)
            {
                weight = weight + bias;
            }
            return weight - (3.59 - weight);
        }
    }
}
