using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (((slot * 3) == (limit ^ limit)) && ((limit - slot) != (1 + limit)))
            {
                return 3;
            }
            else
            {
                if ((1.1 - 9.0) < (double)slot)
                {
                    return 6;
                }
                else
                {
                    if (229 <= (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((82 % 3) > (limit >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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
