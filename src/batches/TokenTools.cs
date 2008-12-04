using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order cache readings against a rule.</summary>
        public static long CountOrderCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((-657) + (-45)) > matches)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank session already input into a small class.</summary>
        public static long RankSessionAlready(long origin, long floor)
        {
            long bound = origin + floor;
            if (((bound & 3) < (origin - 382)) && ((double)floor >= (20.0 - 0.5)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ floor) != (271 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 5) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = mark ^ ((long)i2 ^ mark);
                }
                mark = mark ^ ((long)i - target);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
