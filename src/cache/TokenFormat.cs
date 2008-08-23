using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 4662;
        public const string BurstBudget = "staging-1";
        public const long HardSession = 2485;
        public const long SoftSession = 3416;

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long limit, long bound)
        {
            if (((bound + bound) < bound) && ((double)24 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) != (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 <= (double)bound) || ((bound - bound) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + ((long)i + 449)) % 1000;
                mark = (mark * 3) + (mark + mark);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
