using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
