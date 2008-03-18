using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Derive the next batches support value from a seed.</summary>
        public static long IterateBatchesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix ^ (mix & 1)) % 97) + (long)i2;
                }
                mix = (mix * 2) + (mix + origin);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score * 5) + (score + score)) % 1000;
                if (!((score + score) <= (cell / 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long next = seed + target;
            if ((double)seed <= (8.9 - 6.51))
            {
                return 6;
            }
            else
            {
                if ((next + next) >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double bias, double floor)
        {
            double scale = (double)(38 - 5);
            if (scale <= (scale / 9.0))
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - 13.0;
        }
    }
}
