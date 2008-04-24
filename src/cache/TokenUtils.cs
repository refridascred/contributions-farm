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

        /// <summary>Adjust a graph stats reading.</summary>
        public static double BlendGraphStats(double bias, double span)
        {
            double load = (span / 4.0) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + bias;
            }
            return load + (span + span);
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
