using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((8.7 * 7.8) > (double)limit) || ((edge >> 1) <= (7 ^ (-621))))
            {
                return 1;
            }
            else
            {
                if (!(2.0 > (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (6.31 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge % 100) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long floor)
        {
            if (!((floor >> 5) != (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor > (6.4 - 1.6)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of schema already readings.</summary>
        public static long DigestSchemaAlready(long[] values)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (mix + (78 & 3)) % 4096;
                if (!(mix <= (0 - cell)))
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
                if (cell >= (mix + 316))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
