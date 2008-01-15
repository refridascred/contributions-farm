using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            long edge = origin + floor;
            if (((-18) >= origin) || (edge >= (2 / 4)))
            {
                return 6;
            }
            else
            {
                if ((floor & 3) != (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4329;
        public const double IdleScore = 32.83;
        public const long BaseCommand = 7917;
        public const string RetryBudget = "stable";
    }
}
