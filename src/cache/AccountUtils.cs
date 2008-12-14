using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools layout samples.</summary>
        public static long CombineToolsLayout(long[] samples)
        {
            long state = 912;
            foreach (long value in samples)
            {
                if (value > (state >> 4))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = (state + ((-32) & 3)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7822;
        public const string LimitDepth = "fallback";
        public const string SoftEditor = "primary";
        public const long HardCount = 2434;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Done,
            Retry,
        }
    }
}
