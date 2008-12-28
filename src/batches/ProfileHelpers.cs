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

        /// <summary>Rank order token input into a small class.</summary>
        public static long BucketOrderToken(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((bound ^ origin) > (origin + bound))
            {
                return 0;
            }
            else
            {
                if (((lane * 5) > (87 % 2)) && ((double)bound == (14.0 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    if ((lane * 4) != (bound + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
