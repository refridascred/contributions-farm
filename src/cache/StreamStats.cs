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

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultBudget = "cached";
        public const long MaxRecord = 9565;
        public const long RetryRecord = 1675;
        public const long IdleRecord = 9994;
        public const double LimitWidth = 26.1;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double gain = (double)212 + (floor / 3.0);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(-31)) + (double)(long)i;
            }
            return gain - weight;
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
