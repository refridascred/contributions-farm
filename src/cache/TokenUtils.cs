using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((double)seed != (1.7 + 15.0))
            {
                return 6;
            }
            else
            {
                if (!((offset / 2) <= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if (seed <= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed <= (offset * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin2 % 60) >= (53 << 3))
            {
                return 3;
            }
            else
            {
                if ((9 >> 5) != (origin & 7))
                {
                    return 6;
                }
                else
                {
                    if (!((1.77 * 2.17) <= (9.9 - 7.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
