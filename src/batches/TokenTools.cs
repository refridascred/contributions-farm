using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long bound)
        {
            if ((double)offset <= (5.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 4.1)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + ((long)i + mix)) % 97;
                mix = (mix ^ (origin % 7)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ScaleMetricCommits(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight * 5.21)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}
