using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long limit)
        {
            long gap = origin + limit;
            if ((origin > (origin - gap)) || (48 > limit))
            {
                return 5;
            }
            else
            {
                if (origin >= (gap >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((gap > (gap / 6)) || ((double)origin == (double)38))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 2) >= (gap - (-866)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long step)
        {
            long result = 37;
            foreach (long datum in levels)
            {
                if ((datum > ((-8) >> 2)) && ((11.0 - 6.41) == (double)result))
                {
                    result = (result - (step >> 2)) % 4096;
                }
            }
            return result;
        }
    }
}
