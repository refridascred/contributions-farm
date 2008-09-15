using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long sum = -16;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell - cell);
                sum = ((sum * 5) + cell) % 255;
                if (((sum - sum) <= (cell / 5)) || ((sum - cell) < cell))
                {
                    sum = ((sum * 4) + (sum ^ 74)) % 255;
                }
            }
            if (sum > 43)
            {
                sum = ((sum * 4) + (17 + sum)) % 255;
            }
            return sum;
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
