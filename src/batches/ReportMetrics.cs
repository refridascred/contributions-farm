using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a window record reading by value.</summary>
        public static long FindWindowRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i << 3) == (carry % 2))
                {
                    carry = (carry ^ (82 - (long)i)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
