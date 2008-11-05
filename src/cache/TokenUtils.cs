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

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series)
        {
            long result = 62;
            foreach (long reading in series)
            {
                if (((7 + reading) == (53 & 31)) || (result >= (result >> 3)))
                {
                    result = ((result * 4) + (492 + result)) % 1000;
                }
            }
            if (result < 2)
            {
                result = result ^ (result % 97);
            }
            return result % 1000;
        }
    }
}
