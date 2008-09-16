using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a token stats sample.</summary>
        public static long FindTokenStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double gain2 = floor - (gain - floor);
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)17) + (double)(long)i;
            }
            return gain2 - (6.1 / 4.0);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
