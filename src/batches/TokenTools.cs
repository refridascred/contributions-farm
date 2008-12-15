using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "alpha-1";
        public const long RetrySpan = 953;
        public const long MinDepth = 4475;
        public const string BaseGithubfarm = "legacy-v2";
        public const long BatchGithubfarm = 9965;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 3728;
        public const long BatchTools = 7247;
        public const long BurstSize = 1205;
        public const long DefaultLevel = 3276;
        public const long StepLevel = 5169;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((matches ^ (long)values.Length) <= (matches >> 5)) || (matches >= (6 ^ matches))))
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
