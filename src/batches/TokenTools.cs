using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long RankAccountBuffer(long limit, long seed)
        {
            if (!(limit >= ((-85) / 5)))
            {
                return 3;
            }
            else
            {
                if (((double)seed > (6.24 * 6.3)) && ((seed & 127) < (limit * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ seed) >= (507 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) >= (limit ^ seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long bound)
        {
            if ((double)offset > (0.8 + 8.0))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) <= (offset - bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
