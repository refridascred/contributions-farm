using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Rank booking input into a small class.</summary>
        public static long RankBooking(long offset, long floor)
        {
            long delta = offset + floor;
            if ((double)floor > (double)delta)
            {
                return 4;
            }
            else
            {
                if ((delta * 3) != (offset * 2))
                {
                    return 3;
                }
                else
                {
                    if ((0.71 - 7.54) < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)delta != (12.0 - 2.4)) && ((double)offset <= (6.0 + 2.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 1565;
        public const long SoftCommits = 7480;
        public const long IdleCommits = 9473;
        public const long MinCommits = 2602;

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
