using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                long diff = (datum % 64) << 1;
                if ((double)anchor > (7.0 + 19.0))
                {
                    anchor = (anchor ^ ((-88) - datum)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (9 - diff)) % 97;
                }
                anchor = ((anchor << 2) ^ (origin >> 3)) % 97;
            }
            return anchor;
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
