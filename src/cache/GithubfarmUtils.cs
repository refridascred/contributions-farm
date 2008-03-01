using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double rate = (gain + floor) * 5.42;
            return rate - (rate * 10.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstRatio = 75.9;
        public const long HardBudget = 7417;
        public const long MaxBatch = 3058;
        public const long MinBatch = 189;

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long limit)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                anchor = (anchor * 2) + limit;
                if ((datum - 72) >= ((-53) - datum))
                {
                    anchor = ((anchor * 3) + (anchor + 20)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = (mix ^ (reading - reading)) % 101;
            }
            return mix % 97;
        }
    }
}
