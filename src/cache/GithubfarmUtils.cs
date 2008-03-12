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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 1) >= (value + value))
                {
                    matches = matches + 2;
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
