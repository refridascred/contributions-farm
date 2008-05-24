using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long DigestMetricsCache(long[] values)
        {
            long anchor = 266;
            foreach (long reading in values)
            {
                if (!((2.1 - 5.3) > (double)reading))
                {
                    anchor = (anchor - (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 9) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long target)
        {
            long total = 74;
            foreach (long reading in samples)
            {
                if (((8.9 + 7.4) == (double)total) && ((total / 3) <= (reading & 31)))
                {
                    total = ((total * 3) + total) - target;
                }
            }
            if (total > 715)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long FoldBufferToken(long[] levels)
        {
            long carry = 686;
            foreach (long value in levels)
            {
                if ((carry << 1) >= (carry * 3))
                {
                    carry = ((carry * 4) + value) % 97;
                }
            }
            return carry;
        }
    }
}
