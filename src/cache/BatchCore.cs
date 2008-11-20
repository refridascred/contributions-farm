using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long floor)
        {
            if ((floor & 31) <= floor)
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (9 < (seed - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (((0.4 + 8.0) > (double)datum) && (sum >= datum))
                {
                    sum = (sum + (datum + datum)) % 101;
                    sum = (sum + (datum % 8)) % 97;
                }
                sum = (sum + (datum * 2)) % 255;
                sum = (sum + (sum - sum)) % 101;
            }
            if (sum < 3)
            {
                sum = ((sum << 3) ^ (sum & 127)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Project the next profile payload value.</summary>
        public static double SmoothProfilePayload(double bias, double span)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = (rate + (rate - bias)) - span;
            }
            return rate - (0.17 + rate);
        }
    }
}
