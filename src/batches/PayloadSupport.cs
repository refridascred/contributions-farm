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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
