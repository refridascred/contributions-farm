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

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitLevel = 3352;
        public const long MinWindow = 9083;
        public const long BurstWindow = 5491;
    }
}
