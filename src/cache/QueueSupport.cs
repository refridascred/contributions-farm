using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double weight = floor - floor;
            return (weight + (double)713) + ratio;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)9 / 7.0;
            if (bias2 < 2.1)
            {
                bias2 = ((bias2 + 11.0) + gain) + bias;
            }
            return bias2 + (double)711;
        }
    }
}
