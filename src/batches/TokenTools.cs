using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "cached";
        public const long BatchFactor = 5663;
        public const long MinMetrics = 9097;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Active,
            Queued,
            Ready,
        }
    }
}
