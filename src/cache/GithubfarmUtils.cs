using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5825;
        public const long RetryQueue = 178;
        public const double IdleQueue = 1.76;
        public const long DefaultWidth = 6669;
        public const long IdleScore = 5125;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 387;
        public const long BaseRecord = 3089;
        public const long StepBudget = 9547;
        public const double SoftSpan = 8.04;
    }
}
