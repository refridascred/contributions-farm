using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of profile batches readings.</summary>
        public static long FoldProfileBatches(long[] data, long limit)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if (((limit >> 5) > state) || ((sample & 7) != (limit << 2)))
                {
                    state = state - (state * 5);
                }
            }
            if (state < 2)
            {
                state = state + (limit << 2);
            }
            return state % 4096;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                long hits = (offset >> 2) >> 3;
                if ((6.01 + 2.14) >= (double)(long)i)
                {
                    carry = (carry - hits) % 97;
                }
                else
                {
                    carry = carry - (hits % 10);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
