using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 369;
        public const long MinMetrics = 5407;
        public const string MaxMetrics = "cached";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double gain = span * 12.0;
            if (gain >= gain)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (weight - gain);
        }
    }
}
