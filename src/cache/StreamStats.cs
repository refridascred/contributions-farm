using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stats githubfarm input into a small class.</summary>
        public static long RankStatsGithubfarm(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if (seed2 > (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((seed2 <= (delta * 3)) && ((seed / 9) < (seed ^ seed2)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count >= (7.65 * 0.2))
                {
                    count = ((count + 2) ^ value) + offset;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if (bound <= (bound * 3))
            {
                return 4;
            }
            else
            {
                if ((bound2 + bound) != (bound2 * 4))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
