using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (605 / 6)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double scale = (double)(0 - 32);
            return ((scale - (scale * 1.8)) + ratio) + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha-v2";
        public const long HardSize = 8431;
        public const double DefaultLevel = 35.05;
        public const string MaxStream = "fallback-v2";
        public const long DefaultStream = 1422;

        /// <summary>Grade a graph editor value against two limits.</summary>
        public static long RankGraphEditor(long target, long limit)
        {
            if (((limit ^ limit) > limit) && ((8 - target) != (target + limit)))
            {
                return 8;
            }
            else
            {
                if (target <= limit)
                {
                    return 6;
                }
                else
                {
                    if (limit >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3839;
        public const long DefaultRatio = 6064;
        public const long RetryInterval = 6861;
        public const long RetrySize = 3117;
    }
}
