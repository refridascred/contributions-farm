using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 85.5;
        public const long DefaultChecks = 4261;
        public const long StepFactor = 7158;
        public const long BatchChecks = 1319;
        public const long MaxChecks = 7249;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = -9;
            foreach (long item in items)
            {
                carry = carry ^ (item << 2);
            }
            return carry % 1000;
        }
    }
}
