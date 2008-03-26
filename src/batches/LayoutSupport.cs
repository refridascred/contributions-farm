using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            long next = offset - seed;
            if (((offset ^ seed) != (next + 59)) && (seed <= (seed ^ next)))
            {
                return 2;
            }
            else
            {
                if (((19.0 - 4.8) >= (double)seed) || ((double)offset < 5.68))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (next * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.1 - 1.6) != (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double scale = 3.99 - (gain - offset);
            if (scale >= (double)93)
            {
                scale = scale - (offset + gain);
            }
            return scale + (double)34;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long RollPayloadGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit farm command readings against a rule.</summary>
        public static long TallyFarmCommandOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + hits) > (bound & 1))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
