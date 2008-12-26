using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6103;
        public const long BatchBudget = 8296;
        public const string MaxTimeout = "staging";
        public const long HardSpan = 6155;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
