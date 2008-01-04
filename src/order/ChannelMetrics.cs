using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double bias = 13.0;
            if (bias <= (gain / 7.0))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (gain / 8.0);
        }
    }
}
