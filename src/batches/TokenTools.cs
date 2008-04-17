using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardTimeout = "alpha-1";
        public const long BurstGithubfarm = 1856;
        public const long CacheBudget = 1298;
        public const long BurstCount = 7101;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state * 4) + offset) % 1000) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
