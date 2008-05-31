using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long TotalContributiTools(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 5) + (cell % 12)) % 65521;
                acc = acc + step;
            }
            if (acc > 19)
            {
                acc = ((acc << 3) ^ (step + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 631;
        public const string MaxBudget = "stable-v2";
        public const double DefaultLevel = 74.22;
        public const long BurstRatio = 6361;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Locked,
            Stale,
            Active,
        }
    }
}
