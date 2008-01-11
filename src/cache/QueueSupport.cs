using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double drift = span;
            if (drift <= (5.8 - scale))
            {
                drift = drift + (scale / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 5.9) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 9864;
        public const double SoftFactor = 10.98;
        public const long BurstCount = 830;

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 87.16;
        public const long IdleFactor = 7149;
        public const long MaxDepth = 4750;
        public const string StepWidth = "alpha";
    }
}
