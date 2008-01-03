using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-edge";
        public const double CacheStream = 76.31;
        public const long RetryWidth = 7369;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6407;
        public const double BaseBudget = 42.37;
        public const long WindowDepth = 6087;
        public const long LimitRatio = 4911;
        public const long StepToken = 694;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)4)
            {
                bias = bias - offset;
            }
            return bias - 2.8;
        }
    }
}
