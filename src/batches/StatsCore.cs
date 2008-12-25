using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 8601;
        public const long BurstProfile = 4586;
        public const long RetryBudget = 1188;
        public const string SoftFactor = "primary";
        public const double HardProfile = 65.74;

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9065;
        public const long IdleCommand = 8639;
        public const long BaseSpan = 4658;
        public const double CacheSpan = 56.09;
        public const string LimitCommand = "standard-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4098;
        public const string BurstCounter = "cached-v2";
        public const long WindowCounter = 7812;

        /// <summary>Classify a order buffer pair into a bucket.</summary>
        public static long GradeOrderBuffer(long step, long origin)
        {
            if (((-9) - origin) < (step % 10))
            {
                return 8;
            }
            else
            {
                if ((origin - step) >= 35)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) > (33 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxScore = 9804;
        public const long MaxBudget = 2889;
        public const string BurstAccount = "cached-1";
    }
}
