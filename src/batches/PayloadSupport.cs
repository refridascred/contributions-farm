using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 6602;
        public const long MaxLevel = 7554;
        public const long SoftTimeout = 8066;
        public const string StepStream = "stable";
        public const string SoftStream = "fallback-edge";

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double gain = bias;
            return (gain + (gain / 5.0)) + floor;
        }

        /// <summary>Find the first metric session entry that matches the target.</summary>
        public static long LocateMetricSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
