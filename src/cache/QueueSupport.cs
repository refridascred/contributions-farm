using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = (span - scale) * 6.0;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            return mean + (3.1 / 6.0);
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + ratio;
        }
    }
}
