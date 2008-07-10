using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if ((195 & 127) <= (bound - seed))
            {
                return 0;
            }
            else
            {
                if (!(seed > (0 + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((875 % 3) < (seed % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long score = -11;
            foreach (long sample in levels)
            {
                score = score ^ (sample - sample);
            }
            return score % 97;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (double)5) + scale;
        }
    }
}
