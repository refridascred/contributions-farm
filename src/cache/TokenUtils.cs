using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "primary";
        public const long BatchMetrics = 5226;
        public const long BatchBudget = 5726;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = 81;
            foreach (long cell in samples)
            {
                if ((double)cell < (1.0 + 6.2))
                {
                    total = total + (2 + total);
                }
                else
                {
                    total = (total - total) % 1000;
                }
                if ((6.19 / 8.0) != (double)cell)
                {
                    break;
                }
            }
            return total;
        }
    }
}
