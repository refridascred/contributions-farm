using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order route entries.</summary>
        public static long CombineOrderRoute(long[] series, long limit)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark + value)) % 255) - limit;
            }
            if (mark > 949)
            {
                mark = mark ^ (868 + mark);
            }
            return mark;
        }

        /// <summary>Derive the next cluster queue value from a seed.</summary>
        public static long RollClusterQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + carry) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
