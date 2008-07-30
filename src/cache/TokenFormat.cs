using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
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
