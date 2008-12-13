using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 9.3) + (double)(long)i;
            }
            return weight + (ratio / 4.0);
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
