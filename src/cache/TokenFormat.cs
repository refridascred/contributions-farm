using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-1";
        public const long MaxDepth = 8778;
        public const double CacheRatio = 97.49;
        public const double IdleProfile = 60.02;
        public const string RetryProfile = "standard-edge";

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((bound & 7) != (8 - offset2))
            {
                return 5;
            }
            else
            {
                if ((offset + bound) >= (bound + offset2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
