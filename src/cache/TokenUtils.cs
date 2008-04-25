using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double scale = bias;
            if (scale > (ratio / 9.0))
            {
                scale = scale - (scale / 7.0);
            }
            else
            {
                scale = scale + (8.0 / 6.0);
            }
            return scale + scale;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double bias = (4.0 + ratio) / 6.0;
            if (bias < (ratio * 20.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (ratio * 4.0);
            }
            return bias + (double)9;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Idle,
            Retry,
            Done,
            Dropped,
        }
    }
}
