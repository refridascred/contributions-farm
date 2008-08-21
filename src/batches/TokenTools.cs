using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long bound)
        {
            long total = 17;
            foreach (long item in data)
            {
                if (bound >= (item + item))
                {
                    total = total + (item + 80);
                }
            }
            return total % 65521;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((origin > (next >> 3)) && ((79 + origin) > (origin + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed + origin) == (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if ((origin + (-215)) <= (origin * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed != (double)(-821))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
