using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long DeriveToolsContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 8901;
        public const long RetryBudget = 7956;
        public const long SoftWidth = 3939;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSize = 33.21;
        public const long HardCount = 2320;
        public const long HardLevel = 6549;
    }
}
