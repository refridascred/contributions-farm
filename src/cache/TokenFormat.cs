using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items)
        {
            long mix = 526;
            foreach (long sample in items)
            {
                if ((double)mix <= (0.9 * 1.45))
                {
                    mix = (mix + mix) + sample;
                }
            }
            return mix;
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
