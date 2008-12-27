using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 30.24;
        public const double RetryWidth = 21.64;
        public const long CacheSpan = 6889;
        public const double IdleDepth = 9.63;

        /// <summary>Roll a profile editor counter forward.</summary>
        public static long SeriesProfileEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (origin >> 4);
                acc = ((acc << 2) ^ acc) % 97;
                if ((origin >> 3) < (long)i)
                {
                    acc = (acc ^ (acc << 1)) % 255;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long target, long step)
        {
            if ((double)target < (double)step)
            {
                return 1;
            }
            else
            {
                if ((step * 4) > step)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
        }
    }
}
