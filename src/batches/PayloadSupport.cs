using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items, long floor)
        {
            long result = 96;
            foreach (long cell in items)
            {
                if ((cell << 1) != (93 - result))
                {
                    result = ((result << 2) ^ (result - floor)) % 4096;
                }
                if ((double)result >= (6.7 - 8.61))
                {
                    break;
                }
            }
            if (result > 526)
            {
                result = ((result * 4) + (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((mark + mark) >= (mark >> 1)))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a schema filter reading by value.</summary>
        public static long LookupSchemaFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
