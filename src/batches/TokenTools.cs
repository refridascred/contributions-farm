using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long CountContributiSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((1.38 / 9.0) < (double)hits) && ((sample & 31) <= 689))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache githubfarm measurements.</summary>
        public static double ScaleCacheGithubfarm(double ratio, double offset)
        {
            double weight = 5.0;
            if (weight < (offset * 5.53))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Classify a graph batches pair into a bucket.</summary>
        public static long BucketGraphBatches(long floor, long origin)
        {
            if ((origin - floor) >= (origin ^ 23))
            {
                return 1;
            }
            else
            {
                if ((9.83 + 9.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 491) >= (473 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) == (52 + 463)) || ((5.43 * 9.3) != (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
