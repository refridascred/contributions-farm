using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items, long limit)
        {
            long carry = 94;
            foreach (long sample in items)
            {
                carry = (((carry * 3) + (carry & 3)) % 65521) + sample;
            }
            if (carry > (-575))
            {
                carry = (carry << 2) ^ (limit & 7);
            }
            return carry % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long state = 27;
            foreach (long item in levels)
            {
                state = (state ^ ((long)levels.Length ^ state)) % 1000;
                if (!(bound >= (bound << 2)))
                {
                    state = (state * 4) + (state + item);
                }
            }
            return state % 97;
        }
    }
}
