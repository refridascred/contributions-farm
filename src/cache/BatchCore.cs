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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
