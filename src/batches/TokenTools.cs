using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (double)30)
            {
                bias = bias - 19.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + (ratio * 8.48);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
