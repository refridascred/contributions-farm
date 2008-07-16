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

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels, long offset)
        {
            long sum = 90;
            foreach (long cell in levels)
            {
                sum = (sum - (40 + sum)) % 1000;
                sum = (sum ^ (743 + cell)) % 255;
                if ((double)offset < (double)942)
                {
                    sum = sum ^ (offset * 4);
                }
            }
            return sum;
        }

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
