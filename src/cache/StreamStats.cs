using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSize = "standard-1";
        public const long CacheSupport = 1471;
        public const long SoftSupport = 2694;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = weight + (double)(-695);
            if (rate >= (double)51)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - floor;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double bias = scale;
            if (bias < (offset + 3.0))
            {
                bias = bias - scale;
            }
            return bias - (offset + offset);
        }
    }
}
