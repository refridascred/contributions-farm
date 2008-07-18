using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell << 3) > (cell & 127)) || !((double)cell > (15.0 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Ready,
            Pending,
            Dropped,
        }
    }
}
