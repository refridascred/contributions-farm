using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the batches schema series from a seed.</summary>
        public static long IterateBatchesSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 4) + (target ^ 6);
                carry = (carry * 2) + (667 % 7);
                carry = (carry - (long)i) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 1546;
        public const long LimitFactor = 7485;
        public const long MaxContext = 3899;
        public const string WindowContext = "standard-v2";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
