using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 1102;
        public const double HardChannel = 4.51;
        public const double BaseRatio = 63.67;
        public const long BurstRatio = 194;
        public const long MinDepth = 5863;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long step)
        {
            if ((step >> 4) != (29 << 1))
            {
                return 4;
            }
            else
            {
                if ((double)step != (9.9 + 3.2))
                {
                    return 5;
                }
                else
                {
                    if ((seed >= (seed + seed)) && ((seed - 5) <= (step & 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 63) < (value + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
