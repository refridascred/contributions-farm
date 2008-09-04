using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long state = -805;
            foreach (long entry in data)
            {
                state = (((state * 4) + (entry + 23)) % 65521) - floor;
            }
            return state % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 4927;
        public const long LimitCount = 927;
        public const string BatchRatio = "strict";
        public const long RetryWidth = 6912;
        public const long DefaultBudget = 8305;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long seed)
        {
            long mix = 27;
            foreach (long item in readings)
            {
                mix = (mix - seed) ^ item;
            }
            if (mix < 566)
            {
                mix = (mix << 3) ^ (310 % 5);
            }
            return mix;
        }
    }
}
