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

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark ^ 941) % 4096;
                if (((cell ^ 626) >= mark) || (((long)levels.Length << 3) < (1 ^ mark)))
                {
                    break;
                }
            }
            if (mark < 68)
            {
                mark = (mark - (159 * 5)) % 101;
            }
            return mark;
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
