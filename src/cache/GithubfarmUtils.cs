using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a stats route figure with a bias.</summary>
        public static double AdjustStatsRoute(double scale, double bias)
        {
            double scale2 = 1.36;
            if (scale2 > scale2)
            {
                scale2 = (scale2 - 8.5) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + bias) - (double)(long)i;
            }
            return scale2 + (double)33;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (mark * 4)) % 255) + origin;
                mark = ((mark << 3) ^ sample) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long mark = 31;
            foreach (long sample in values)
            {
                if ((12.0 + 7.8) >= (double)sample)
                {
                    mark = ((mark * 5) + (9 ^ sample)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long result = 6;
            foreach (long sample in data)
            {
                if ((result ^ limit) >= (103 % 7))
                {
                    result = ((result << 3) ^ (sample >> 4)) % 101;
                }
            }
            return result;
        }
    }
}
