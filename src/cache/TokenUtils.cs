using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= 2.3)
            {
                bias2 = (bias2 + (double)96) - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Check that every batch metric entry stays within the limit.</summary>
        public static bool CheckBatchMetricLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Done,
            Locked,
            Pending,
            Paused,
        }
    }
}
