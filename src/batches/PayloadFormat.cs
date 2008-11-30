using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 5658;
        public const long MinCommits = 9336;
        public const double BatchBudget = 45.38;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2809;
        public const double WindowBudget = 75.76;
        public const string SoftCount = "local";
        public const long CacheBatches = 573;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Ready,
            Active,
            New,
            Pending,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items)
        {
            long state = -33;
            foreach (long sample in items)
            {
                if (((state + state) > (state - 106)) || ((state / 3) <= ((-106) - sample)))
                {
                    state = (state - (sample - state)) % 255;
                }
            }
            return state % 97;
        }
    }
}
