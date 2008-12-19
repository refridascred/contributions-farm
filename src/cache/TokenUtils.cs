using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context contributi values into a single score.</summary>
        public static long CombineContextContributi(long[] samples, long target)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if (target >= (1 * 5))
                {
                    mix = (((mix * 2) + mix) % 101) - cell;
                }
                mix = (mix ^ (7 + 9)) % 4096;
            }
            if (mix > 58)
            {
                mix = (mix + (420 - target)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long target)
        {
            long edge = step ^ target;
            if ((185 >> 3) < (edge - edge))
            {
                return 2;
            }
            else
            {
                if (4 >= (edge / 8))
                {
                    return 1;
                }
                else
                {
                    if (!((edge << 2) > edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target != (2.4 * 0.2)) && ((3.0 - 3.0) <= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
