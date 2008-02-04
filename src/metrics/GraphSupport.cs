using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches counter readings.</summary>
        public static long OverlapBatchesCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a window schema reading.</summary>
        public static double ProjectWindowSchema(double gain, double span)
        {
            double rate = gain;
            if (rate > span)
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (2.82 / 2.0)) - (double)(long)i;
            }
            return rate + (double)4;
        }
    }
}
