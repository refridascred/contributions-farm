using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long WeighGithubfarmChecks(long[] samples, long target)
        {
            long state = 51;
            foreach (long value in samples)
            {
                state = (state * 4) + (value - target);
            }
            return state;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8211;
        public const long HardSpan = 7822;
        public const string LimitSpan = "alpha-edge";
        public const double CacheChannel = 73.39;
        public const double BurstChannel = 9.85;
    }
}
