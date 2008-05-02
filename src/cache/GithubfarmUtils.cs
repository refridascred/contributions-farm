using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long seed)
        {
            long mark = -984;
            foreach (long sample in values)
            {
                if ((seed ^ seed) > (seed & 1))
                {
                    mark = ((mark - mark) % 101) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (bias / 5.0) + bias;
            if (ratio >= (double)987)
            {
                ratio = ratio - (7.8 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 4.86) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitCount = 1570;
        public const long BaseContext = 5072;
        public const double BatchTimeout = 30.34;
        public const long MaxWidth = 952;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = 2.0 - (double)915;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + 15.0) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (span / 6.0);
        }
    }
}
