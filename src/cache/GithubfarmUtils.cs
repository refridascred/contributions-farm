using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((seed2 + seed2) < span)
            {
                return 0;
            }
            else
            {
                if ((4.1 + 6.31) < (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed2 / 3) <= (8 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
