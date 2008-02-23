using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (6 <= (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) > seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed + offset) > (prev - 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long bound, long seed)
        {
            long step = bound - seed;
            if ((seed - step) == (bound + seed))
            {
                return 1;
            }
            else
            {
                if (bound >= 76)
                {
                    return 8;
                }
                else
                {
                    if (43 <= (1 + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step ^ seed) <= (bound & 7)) && ((9.5 / 6.0) >= (double)seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor farm sample.</summary>
        public static long SeekEditorFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
