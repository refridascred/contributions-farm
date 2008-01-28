using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long result = -23;
            foreach (long sample in items)
            {
                result = result - ((-35) & 31);
                if (((offset + sample) == (offset - 59)) || ((result >> 3) > (offset << 3)))
                {
                    break;
                }
            }
            if (result > 12)
            {
                result = ((result * 3) + (offset << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (double)carry)
                {
                    carry = ((carry * 4) + (carry + bound)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
