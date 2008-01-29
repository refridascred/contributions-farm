using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long LocateChannelStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (limit > (bound & 3))
            {
                return 8;
            }
            else
            {
                if (((double)cur <= (3.44 + 5.0)) || ((0.5 + 4.0) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (cur > (bound / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            long next = origin ^ origin2;
            if (((4.5 * 7.54) <= (double)next) || ((origin + (-647)) < next))
            {
                return 5;
            }
            else
            {
                if (5.97 < (double)origin2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
