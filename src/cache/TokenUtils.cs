using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long floor)
        {
            long cur = target + floor;
            if ((cur - cur) <= (cur + cur))
            {
                return 7;
            }
            else
            {
                if ((607 + target) < cur)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long target, long origin)
        {
            if (((double)origin > (6.5 / 3.0)) && ((target + 239) == (829 ^ 149)))
            {
                return 6;
            }
            else
            {
                if ((target & 3) > (764 + target))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= 9.9)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(origin < 59))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
