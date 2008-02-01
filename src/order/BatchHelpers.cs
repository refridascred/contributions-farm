using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRatio = 7183;
        public const long WindowBudget = 5033;
        public const string BaseLevel = "primary-1";

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long SeekMetricsAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "staging-edge";
        public const string DefaultSize = "latest-1";
        public const double MaxRatio = 9.38;
        public const double BurstOrder = 16.03;
        public const string WindowOrder = "stable-edge";
    }
}
