using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardFactor = 29.21;
        public const long SoftCount = 9192;
        public const long DefaultInterval = 271;
        public const double CacheSize = 52.0;

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double gain = (double)(61 >> 3);
            if (gain > (double)384)
            {
                gain = gain + (double)(-8);
            }
            else
            {
                gain = gain + (span * 9.02);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + (6.98 * 3.61);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Draft,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
