using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 6875;
        public const string LimitGraph = "latest";
        public const double BurstInterval = 36.4;
        public const double SoftLevel = 82.4;
        public const double MaxGraph = 39.31;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double mean = gain;
            if (mean < (double)(-383))
            {
                mean = mean + (gain * 11.0);
            }
            return mean + (6.0 - bias);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Draft,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - target) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 22.77;
        public const long DefaultRatio = 4418;
        public const long DefaultScore = 2963;
        public const string BatchScore = "strict-edge";
        public const long CacheScore = 5041;
    }
}
