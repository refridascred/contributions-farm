using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 98.82;
        public const long BaseStream = 8396;
        public const string BurstStream = "staging-v2";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (score - score)) % 1000;
                long delta = (84 << 1) / 7;
                score = (score - (delta << 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
