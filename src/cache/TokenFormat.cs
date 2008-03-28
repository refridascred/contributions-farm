using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long origin)
        {
            long carry = 853;
            foreach (long entry in values)
            {
                if (((double)39 > (double)carry) && ((34 ^ (long)values.Length) > entry))
                {
                    carry = (carry * 3) + (origin ^ (long)values.Length);
                }
            }
            if (carry > 31)
            {
                carry = ((carry * 4) + (carry + origin)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long ClassifyFilterCache(long seed, long limit)
        {
            long step = seed + limit;
            if (((double)step >= 2.26) || ((step << 2) > step))
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) < step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
