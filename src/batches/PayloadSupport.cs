using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 5651;
        public const double MaxMetric = 40.45;
        public const string LimitMetric = "stable-edge";
        public const double MinTimeout = 42.18;
        public const long HardMetric = 6107;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
