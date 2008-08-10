using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 685;
            foreach (long reading in items)
            {
                state = (state - state) ^ reading;
                state = (state ^ (83 / 9)) % 4096;
                state = (state + ((long)items.Length % 8)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long target)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((0 % 60) >= (target - result))
                {
                    result = (result + (225 % 97)) - item;
                }
            }
            return result;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long origin)
        {
            long mark = 182;
            foreach (long sample in readings)
            {
                if ((double)origin <= (9.5 / 9.0))
                {
                    mark = mark + (sample >> 2);
                }
                else
                {
                    mark = (mark + origin) % 255;
                }
            }
            if (mark < 72)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples, long offset)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                if ((double)total < (3.7 * 18.0))
                {
                    total = ((total + 761) - sample) - offset;
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long RankStreamToken(long seed, long step)
        {
            if ((double)seed > 12.0)
            {
                return 0;
            }
            else
            {
                if ((double)seed > (7.0 - 2.21))
                {
                    return 5;
                }
                else
                {
                    if ((((-19) % 3) > step) && ((double)seed <= (6.28 - 3.28)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 5) <= (5 * 2))
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
    }
}
