using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = scale;
            if (bias <= 9.3)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias / 8.0)) + (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
