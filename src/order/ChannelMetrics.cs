using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (bias + bias) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] levels)
        {
            long mix = 54;
            foreach (long value in levels)
            {
                mix = ((mix ^ (2 + mix)) % 1000) ^ value;
            }
            return mix % 1000;
        }
    }
}
