using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a already cache pair into a bucket.</summary>
        public static long GradeAlreadyCache(long target, long seed)
        {
            if (((2.0 / 2.0) == (double)seed) && ((2 / 4) != (target + seed)))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (5.0 + 9.0))
                {
                    return 5;
                }
                else
                {
                    if (target > (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < (target << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading == (3.8 * 19.0)) && ((reading % 64) == (hits + hits)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double bias)
        {
            double bias2 = (double)(7 - 1);
            if (bias2 <= scale)
            {
                bias2 = (bias2 - 8.1) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + 17.0) + (double)(long)i;
            }
            return bias2 - (0.89 * 2.46);
        }
    }
}
