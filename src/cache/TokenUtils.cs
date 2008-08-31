using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long limit)
        {
            if ((limit << 3) > limit)
            {
                return 7;
            }
            else
            {
                if ((limit + limit) != (limit / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 9040;
        public const double MinOrder = 79.71;
        public const long StepOrder = 1247;
        public const double CacheOrder = 26.71;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= 8.8)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
