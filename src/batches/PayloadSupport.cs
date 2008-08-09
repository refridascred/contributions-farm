using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5927;
        public const long BaseAccount = 2596;
        public const double MaxBudget = 70.18;

        /// <summary>Rank entry farm input into a small class.</summary>
        public static long RankEntryFarm(long offset, long bound)
        {
            if ((76 < (bound - bound)) && ((20.0 / 7.0) == (double)bound))
            {
                return 7;
            }
            else
            {
                if (((bound - 564) > (bound - offset)) && ((offset - bound) < (725 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((5 ^ bound) == (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
