using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batches context entry stays within the limit.</summary>
        public static bool CheckBatchesContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long limit)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if (carry <= (value + limit))
                {
                    carry = carry + 33;
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double BlendCacheSession(double ratio, double offset)
        {
            double rate = (ratio / 7.0) - offset;
            if (rate > (double)16)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio * 8.1);
        }
    }
}
