using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 90.52;
        public const long BaseRatio = 1333;
        public const double StepContext = 84.35;

        /// <summary>Adjust a channel metrics reading.</summary>
        public static double SmoothChannelMetrics(double bias, double offset)
        {
            double load = offset;
            if (load < load)
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)(-2)) - (double)(long)i;
            }
            return load - (double)903;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitFactor = 8504;
        public const long DefaultRatio = 3272;
        public const long BatchBudget = 3793;
        public const double LimitCache = 3.41;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5197;
        public const long IdleRatio = 9837;
        public const long LimitRatio = 3328;
    }
}
