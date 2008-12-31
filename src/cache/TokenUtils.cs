using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double ratio2 = (double)(9 + 133);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - (double)4;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSize = 5964;
        public const string WindowAlready = "local-edge";
        public const long StepAlready = 1568;
        public const long CacheAlready = 8351;
        public const long IdleAlready = 747;
    }
}
