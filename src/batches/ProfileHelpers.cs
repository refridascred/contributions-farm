using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long bound)
        {
            long sum = 232;
            foreach (long sample in series)
            {
                sum = ((sum - (bound & 15)) % 97) - sample;
            }
            if (sum < 57)
            {
                sum = (sum ^ (sum * 3)) % 65521;
            }
            return sum % 4096;
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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if ((double)987 >= (double)16)
                {
                    mark = ((mark * 4) + (467 << 1)) % 1000;
                }
                if (((mark + value) == (value ^ mark)) || ((mark << 3) != (64 % 2)))
                {
                    break;
                }
            }
            if (mark > 644)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 4096;
        }
    }
}
