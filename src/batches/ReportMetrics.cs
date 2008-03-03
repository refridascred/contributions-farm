using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long origin, long limit)
        {
            if (!((8.35 / 2.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((6.1 + 17.0) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long TotalQueueBatch(long[] values, long offset)
        {
            long carry = 9;
            foreach (long value in values)
            {
                carry = (((carry * 5) + offset) % 101) ^ value;
            }
            if (carry < 584)
            {
                carry = (carry << 3) ^ 6;
            }
            return carry;
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long RankChannelToken(long origin, long limit)
        {
            if (((limit + limit) != (limit * 5)) || ((limit + limit) == (limit ^ limit)))
            {
                return 0;
            }
            else
            {
                if ((limit & 255) <= (559 << 2))
                {
                    return 5;
                }
                else
                {
                    if (((-6) + limit) > (limit - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin >> 3) < (origin % 16)))
                        {
                            return 4;
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
