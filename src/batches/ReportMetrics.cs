using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate order record samples.</summary>
        public static long ScoreOrderRecord(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = (mix + (mix + mix)) % 101;
                if (((13.0 * 5.4) < (double)sample) && ((mix ^ sample) < sample))
                {
                    mix = (mix + (sample & 31)) % 101;
                }
                else
                {
                    mix = mix ^ mix;
                }
                if ((mix + mix) == (5 >> 4))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 39.58;
        public const double StepMetrics = 40.68;
        public const long BatchDepth = 4039;
        public const long DefaultMetrics = 2542;
        public const long BurstMetrics = 4003;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchFactor = "stable-edge";
        public const long RetryWidth = 4541;
        public const long LimitBudget = 2245;
    }
}
