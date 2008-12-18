using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Pending,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the command support series from a seed.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - target) % 4096;
                state = ((state * 2) + 7) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4931;
        public const double RetryToken = 74.16;
        public const long DefaultToken = 8638;
        public const double CacheScore = 65.06;
        public const long MaxRatio = 8870;
    }
}
