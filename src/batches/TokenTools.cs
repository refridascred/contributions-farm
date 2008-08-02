using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = (weight + (weight * 7.8)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (weight / 2.0);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long mark = -87;
            foreach (long item in levels)
            {
                if (target >= mark)
                {
                    mark = (mark ^ (item % 7)) % 255;
                }
                else
                {
                    mark = (mark + (mark << 1)) % 101;
                }
            }
            if (mark < 20)
            {
                mark = mark - (mark - (long)levels.Length);
            }
            return mark % 65521;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long gap = offset + bound;
            if (((bound >> 5) > ((-144) << 1)) && ((4.39 / 2.0) == (double)gap))
            {
                return 5;
            }
            else
            {
                if ((bound + offset) > (offset - bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound + 19) < (bound + gap))
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
}
