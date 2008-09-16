using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = gain + bias;
            if (bias2 < (gain * 11.0))
            {
                bias2 = bias2 - (bias2 * 3.6);
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 + (gain - bias);
        }
    }
}
