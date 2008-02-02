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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((2.0 / 6.0) < (double)bound)
                {
                    carry = carry - (bound >> 5);
                    break;
                }
                if ((0 + bound) != ((long)i - carry))
                {
                    carry = ((carry * 2) + 3) % 101;
                    carry = (carry ^ ((long)i & 255)) % 255;
                }
                else
                {
                    carry = (carry - carry) % 255;
                }
                if (((2.87 + 1.0) <= (double)bound) || ((carry << 2) != (carry << 1)))
                {
                    carry = ((carry << 3) ^ carry) % 255;
                }
                else
                {
                    carry = (carry * 2) + (bound >> 2);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
