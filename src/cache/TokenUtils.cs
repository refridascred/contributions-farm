using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long target)
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

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 1648;
        public const double MinMetrics = 91.16;
        public const double BatchMetrics = 92.65;
        public const long DefaultMetrics = 4337;
        public const long BurstMetrics = 7385;
    }
}
