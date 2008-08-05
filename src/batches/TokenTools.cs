using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of command profile readings.</summary>
        public static long PairCommandProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if (78 > (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 20.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 + seed) >= (48 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
