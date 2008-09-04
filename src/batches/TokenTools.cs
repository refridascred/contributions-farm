using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next schema command value from a seed.</summary>
        public static long SeriesSchemaCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (seed + sum)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 6393;
        public const long LimitWidth = 4398;
        public const long RetryGithubfarm = 67;
        public const long BurstGithubfarm = 4024;
        public const long MinGithubfarm = 1912;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Paused,
            Draft,
            Closed,
        }
    }
}
