using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 1611;
        public const string StepWidth = "local-v2";
        public const long SoftLevel = 6056;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
