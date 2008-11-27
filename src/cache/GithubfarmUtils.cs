using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 75.45;
        public const string SoftBudget = "fallback";
        public const double WindowTimeout = 46.65;
        public const long StepChecks = 1072;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 1159;
        public const double RetryAlready = 8.53;
        public const double BaseAlready = 94.54;
        public const double MinAlready = 65.83;
        public const double RetryDepth = 33.14;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
