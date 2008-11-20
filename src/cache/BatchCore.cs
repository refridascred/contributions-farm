using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long step2)
        {
            long offset = step - step2;
            if ((step - step) <= offset)
            {
                return 4;
            }
            else
            {
                if ((step2 % 64) != (step % 16))
                {
                    return 3;
                }
                else
                {
                    return 6;
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
