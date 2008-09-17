using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback-edge";
        public const double BurstCount = 29.43;
        public const long LimitSize = 6513;
        public const string SoftCommand = "local-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "latest";
        public const double BurstContributi = 12.83;
        public const long DefaultContributi = 6524;
        public const long MinScore = 3013;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
