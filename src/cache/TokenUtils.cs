using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 16.84;
        public const double RetryBuffer = 46.77;
        public const long WindowRatio = 3310;
        public const long IdleBuffer = 2561;

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double weight = span;
            if (weight > (weight + 15.0))
            {
                weight = weight - (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span * 3.4)) + (double)(long)i;
            }
            return weight + (double)252;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Done,
            Retry,
        }
    }
}
