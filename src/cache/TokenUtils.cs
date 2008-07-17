using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double scale = bias;
            if (scale < (bias + 8.41))
            {
                scale = scale - (weight * 1.8);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight / 3.0)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }
    }
}
