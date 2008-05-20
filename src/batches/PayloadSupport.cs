using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 2127;
        public const double LimitRatio = 19.32;
        public const string DefaultContributi = "alpha-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 5074;
        public const long MinSize = 7422;
        public const long BurstTimeout = 2753;
        public const long BatchMetric = 481;
        public const long IdleMetric = 5709;
    }
}
