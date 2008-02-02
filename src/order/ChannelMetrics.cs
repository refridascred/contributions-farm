using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long DigestOrderContributi(long[] values)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                if ((13.0 * 15.0) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (entry + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry << 3)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
