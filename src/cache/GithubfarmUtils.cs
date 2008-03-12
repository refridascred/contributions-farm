using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc ^ (20 - acc)) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 5761;
        public const long BurstSchema = 4238;
        public const long StepSchema = 7743;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long sum = 454;
            foreach (long value in values)
            {
                sum = ((sum * 4) + (sum - 5)) % 65521;
                if (sum <= value)
                {
                    sum = sum + (value - sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchTimeout = "fallback-1";
        public const double IdleInterval = 74.04;
        public const string IdleRoute = "stable";
    }
}
