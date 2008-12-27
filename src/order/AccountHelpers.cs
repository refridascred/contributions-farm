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

        /// <summary>Locate a command counter reading by value.</summary>
        public static long FindCommandCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Ready,
            Pending,
            Draft,
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
