using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of counter already entries.</summary>
        public static long WeighCounterAlready(long[] samples)
        {
            long mark = 430;
            foreach (long cell in samples)
            {
                if (!(49 < (cell >> 2)))
                {
                    mark = mark - cell;
                }
                if (((cell * 4) <= mark) || ((mark ^ cell) <= mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 3549;
        public const long MinFilter = 578;
        public const long BurstFilter = 83;
        public const long BatchFilter = 5903;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double scale = (floor / 2.0) + (double)27;
            if (scale >= (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (floor / 8.0)) + (double)(long)i;
            }
            return scale + (floor - weight);
        }
    }
}
