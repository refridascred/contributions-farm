using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long RankContextRoute(long seed, long target)
        {
            if ((double)seed > (4.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (18.0 - 6.8))
                {
                    return 1;
                }
                else
                {
                    if ((target >> 1) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the cache githubfarm series from a seed.</summary>
        public static long RollCacheGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = total ^ ((-9) / 4);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = ratio - ratio;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)15) + (double)(long)i) + offset;
            }
            return bias - 1.18;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= offset)
            {
                weight = weight + (double)970;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
