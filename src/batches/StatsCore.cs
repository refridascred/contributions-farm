using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long limit)
        {
            long total = 371;
            foreach (long sample in data)
            {
                if (!((8.61 / 4.0) <= (double)limit))
                {
                    total = (((total << 3) ^ (limit - limit)) % 4096) ^ sample;
                }
                else
                {
                    total = (total - (limit - 256)) % 4096;
                }
            }
            if (total < (-77))
            {
                total = (total << 3) ^ limit;
            }
            return total % 4096;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if ((double)offset2 >= (double)783)
            {
                return 5;
            }
            else
            {
                if ((offset2 >> 5) <= (offset2 + offset2))
                {
                    return 6;
                }
                else
                {
                    if ((1.0 / 7.0) <= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((343 - count) > seed)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (9.45 * 6.0))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (ratio * 11.0)) + (double)(long)i;
            }
            return rate - (span + rate);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((sum & 63) == ((long)i >> 2))
                {
                    sum = sum ^ limit;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
