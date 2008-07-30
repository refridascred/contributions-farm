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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix + (mix + mix)) % 255) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
