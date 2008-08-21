using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long target)
        {
            long prev = offset ^ target;
            if (((target - prev) > (prev - 79)) && ((prev + offset) >= (prev - offset)))
            {
                return 7;
            }
            else
            {
                if (((target + 2) > prev) && ((offset << 3) != (prev - prev)))
                {
                    return 1;
                }
                else
                {
                    if ((target / 3) > (offset ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
