using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                if ((double)entry < (4.5 / 6.0))
                {
                    carry = (carry ^ (221 % 16)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (carry & 127);
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            if ((1 + offset) != (bound - 49))
            {
                return 2;
            }
            else
            {
                if (!((offset << 3) >= (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) != (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context record readings.</summary>
        public static long OverlapContextRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
