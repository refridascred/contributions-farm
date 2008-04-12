using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] readings, long target)
        {
            long sum = 401;
            foreach (long sample in readings)
            {
                if (((double)sample < (8.7 + 2.0)) || ((double)sample > (0.42 - 9.9)))
                {
                    sum = (((sum << 3) ^ (411 / 8)) % 255) - target;
                    continue;
                }
                else
                {
                    sum = sum ^ (sum << 3);
                }
                sum = ((sum * 4) + (sample - 44)) % 255;
                sum = ((sum * 3) + sample) % 1000;
            }
            if (sum < 501)
            {
                sum = (sum - (sum + 80)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long origin)
        {
            if ((floor < (floor + floor)) || ((double)origin == (9.9 * 6.0)))
            {
                return 3;
            }
            else
            {
                if (!((6.2 / 9.0) != (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (10.0 - 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.2 + 9.54) <= (double)origin) && ((floor << 2) <= 41))
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

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long WeighOrderMetric(long[] data, long target)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (((mark << 3) ^ (target >> 5)) % 4096) + entry;
                mark = (mark + mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
