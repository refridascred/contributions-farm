using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 2314;
        public const long BaseChecks = 7681;
        public const long MinWidth = 6520;
        public const long BurstBudget = 3279;
        public const long CacheChecks = 1646;

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values)
        {
            long mix = -72;
            foreach (long sample in values)
            {
                if (!((double)mix >= (9.0 + 8.61)))
                {
                    mix = (mix - (sample - sample)) % 255;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                mix = (mix - sample) % 65521;
                if ((mix ^ mix) < sample)
                {
                    mix = (mix * 2) + (sample * 3);
                }
                else
                {
                    mix = (mix + (mix - mix)) % 1000;
                }
                if (mix < (mix * 4))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long seed2)
        {
            long cur = seed - seed2;
            if (((5 - seed2) > (-21)) || ((1 + 1) == (seed2 ^ 2)))
            {
                return 5;
            }
            else
            {
                if ((cur ^ seed2) <= (seed - cur))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Pending,
        }
    }
}
