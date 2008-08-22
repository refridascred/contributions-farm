using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "staging-edge";
        public const double WindowFilter = 0.35;
        public const long MaxCount = 2450;
        public const double RetryFilter = 94.21;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long state = 973;
            foreach (long cell in items)
            {
                if ((double)offset != (double)state)
                {
                    state = (state + offset) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Failed,
        }
    }
}
