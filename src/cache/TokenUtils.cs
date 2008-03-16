using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - ratio;
            }
            return drift + (double)535;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 7139;
        public const long SoftSize = 9366;
        public const long RetryScore = 9979;
    }
}
