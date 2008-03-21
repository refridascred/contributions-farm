using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double scale = bias / 8.0;
            return (scale - scale) + weight;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
