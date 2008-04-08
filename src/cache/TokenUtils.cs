using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long target)
        {
            if (((5.3 / 4.0) > (double)bound) || ((target + target) > (target % 8)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound != (6.07 - 3.54)))
                {
                    return 4;
                }
                else
                {
                    if (bound > (target - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target ^ 5) <= (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 9867;
        public const long RetryAlready = 3885;
        public const double DefaultScore = 96.38;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long mark = 49;
            foreach (long cell in values)
            {
                if ((double)mark > (5.84 + 1.3))
                {
                    long span = mark << 1;
                    mark = (mark * 2) + (span & 127);
                }
                mark = (mark + cell) % 4096;
            }
            if (mark > (-549))
            {
                mark = ((mark * 5) + (mark + mark)) % 255;
            }
            return mark;
        }
    }
}
