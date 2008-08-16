using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double scale = (double)(399 & 1);
            if (scale > (double)706)
            {
                scale = (scale - (rate - scale)) - offset;
            }
            else
            {
                scale = scale - (double)(-1);
            }
            return scale - (5.74 - scale);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = gain;
            return (ratio - (17.0 * 3.8)) + bias;
        }
    }
}
