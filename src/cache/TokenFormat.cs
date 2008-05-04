using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a context entry pair into a bucket.</summary>
        public static long BucketContextEntry(long limit, long floor)
        {
            if ((floor & 15) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((3 >= (limit / 8)) || ((limit ^ limit) != (floor + floor)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            long delta = origin ^ limit;
            if (limit <= (delta << 1))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) < (delta >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit - delta) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (6.37 * 20.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxSpan = 9.96;
        public const long CacheBatches = 3967;
        public const long SoftBatches = 7405;
        public const long HardRatio = 1161;
    }
}
