using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 433;
            foreach (long reading in readings)
            {
                sum = sum - (sum + sum);
                sum = sum ^ reading;
                sum = (sum + (sum + sum)) % 65521;
            }
            if (sum > 4)
            {
                sum = (sum ^ (82 / 6)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((diff ^ diff) <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > (97 + limit)) || ((seed >> 5) > (limit & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((diff - limit) == (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.59 / 6.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster route samples are out of range.</summary>
        public static long AuditClusterRouteGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
