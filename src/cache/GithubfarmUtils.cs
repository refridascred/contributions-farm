using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryBudget = "strict-1";
        public const long BaseStats = 4194;
        public const string BaseBudget = "local";
        public const long WindowStats = 7888;

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
