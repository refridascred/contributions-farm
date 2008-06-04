using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double weight = ratio - (ratio * 6.0);
            return weight - floor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mark = -55;
            foreach (long value in series)
            {
                mark = (((mark * 2) + (80 / 3)) - value) - seed;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "standard-1";
        public const long LimitGraph = 8637;
        public const long HardGraph = 1648;
        public const string DefaultGraph = "standard-v2";
        public const string MinWidth = "cached-edge";
    }
}
