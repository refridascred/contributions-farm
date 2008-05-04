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

        /// <summary>Rank notes buffer input into a small class.</summary>
        public static long GradeNotesBuffer(long target, long offset)
        {
            long slot = target - offset;
            if (!((slot << 2) > (slot & 15)))
            {
                return 7;
            }
            else
            {
                if ((7 < slot) && ((5.0 + 4.24) == (double)slot))
                {
                    return 5;
                }
                else
                {
                    if (target >= (27 & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.86 * 17.0) < (20.0 + 4.16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - count) > (4 << 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
