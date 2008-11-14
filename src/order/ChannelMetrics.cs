using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)629) + (double)(long)i) - floor;
            }
            return scale + (rate + rate);
        }
    }
}
