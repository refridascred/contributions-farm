using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxDepth = 73.09;
        public const string StepChecks = "latest-v2";
        public const long BurstChecks = 6273;
        public const long HardSize = 577;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 2396;
        public const double BatchTools = 79.9;
        public const long BaseLevel = 6715;

        /// <summary>Fold a list of layout context readings.</summary>
        public static long CombineLayoutContext(long[] items, long target)
        {
            long state = 7;
            foreach (long cell in items)
            {
                if ((double)target <= (double)(-2))
                {
                    state = (state - target) - cell;
                }
            }
            return state;
        }
    }
}
