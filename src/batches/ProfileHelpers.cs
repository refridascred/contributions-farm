using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long target2)
        {
            long gap = target - target2;
            if (target <= (gap + target2))
            {
                return 8;
            }
            else
            {
                if ((target ^ 236) >= (391 >> 5))
                {
                    return 1;
                }
                else
                {
                    if (((3 ^ target) < (31 + target)) || (gap >= (gap << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((gap & 7) == (target2 << 1))
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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of account schema entries.</summary>
        public static long ScoreAccountSchema(long[] data, long target)
        {
            long total = 4;
            foreach (long cell in data)
            {
                total = (total - (target - target)) + cell;
            }
            return total % 4096;
        }

        /// <summary>Rank support window input into a small class.</summary>
        public static long ClassifySupportWindow(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((edge - edge) > (seed - offset))
            {
                return 2;
            }
            else
            {
                if ((edge <= (seed / 8)) && ((seed * 3) >= (seed & 127)))
                {
                    return 3;
                }
                else
                {
                    if ((edge % 97) != (seed ^ edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed << 1) >= (762 - offset)) || ((17.0 * 19.0) != (double)edge))
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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long seed)
        {
            long slot = origin - seed;
            if ((seed + seed) > slot)
            {
                return 8;
            }
            else
            {
                if (((double)slot < (double)88) && ((10.0 - 5.1) < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (seed <= (706 & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((13.0 / 5.0) >= (1.6 / 6.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
