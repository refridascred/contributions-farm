using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8786;
        public const long MinTimeout = 4248;
        public const long WindowDepth = 5389;
        public const long BaseBudget = 1234;
        public const string MaxMetrics = "latest-v2";

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double ratio = (double)79 / 2.0;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + weight;
            }
            return ratio - (double)8;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
