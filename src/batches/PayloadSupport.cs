using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine cluster context values into a single score.</summary>
        public static long FoldClusterContext(long[] levels)
        {
            long mix = -634;
            foreach (long reading in levels)
            {
                if (((mix & 3) > (reading & 3)) && ((6.67 * 11.0) != (double)reading))
                {
                    mix = ((mix * 3) + (reading + reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long carry = 39;
            foreach (long entry in items)
            {
                carry = (carry ^ carry) ^ entry;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8153;
        public const long HardOrder = 7860;
        public const long BatchOrder = 9720;
        public const long SoftInterval = 3702;
        public const double MinFactor = 18.74;
    }
}
