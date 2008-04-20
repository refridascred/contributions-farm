using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool CheckStatsAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long bound)
        {
            long diff = seed + bound;
            if ((bound % 5) == (4 << 2))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound > (9.4 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + bound) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
