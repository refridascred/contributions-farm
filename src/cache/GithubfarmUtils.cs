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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
