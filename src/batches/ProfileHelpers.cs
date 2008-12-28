using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryInterval = 31.6;
        public const long MinWidth = 1710;
        public const long BatchTimeout = 4532;
        public const long BurstLevel = 4047;
        public const long BatchBudget = 6682;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 41.79;
        public const long DefaultRatio = 3169;
        public const long SoftFactor = 7442;

        /// <summary>Rank batch buffer input into a small class.</summary>
        public static long GradeBatchBuffer(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (!((double)lane <= (0.72 + 2.0)))
            {
                return 3;
            }
            else
            {
                if ((limit + lane) >= 2)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
