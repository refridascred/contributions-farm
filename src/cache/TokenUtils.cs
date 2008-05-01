using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long bound)
        {
            long sum = -45;
            foreach (long sample in samples)
            {
                if (30 > (bound ^ (-494)))
                {
                    sum = sum + (sample + 10);
                }
            }
            return sum;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double drift = weight + bias;
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((7.07 + 2.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) < (origin + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 - 1.4) != (double)origin)
                        {
                            return 2;
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
