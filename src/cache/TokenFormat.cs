using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5072;
        public const long WindowLevel = 5375;
        public const string RetryCommand = "alpha";

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (7.0 * 4.85);
        }
    }
}
