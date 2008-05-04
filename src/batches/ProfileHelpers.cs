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

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long offset)
        {
            if (offset < (bound % 12))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) <= (bound % 97))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long step2)
        {
            if (step <= (step2 - step))
            {
                return 5;
            }
            else
            {
                if ((step2 - step2) > step)
                {
                    return 4;
                }
                else
                {
                    return 6;
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
