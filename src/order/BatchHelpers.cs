using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long state = 797;
            foreach (long item in levels)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state << 3) ^ (item + state)) % 4096;
            }
            if (state < 36)
            {
                state = (state - 14) % 101;
            }
            return state;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = result - (long)i;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
