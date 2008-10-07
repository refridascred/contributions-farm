using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 6927;
        public const long HardChecks = 107;
        public const long BaseLevel = 6729;
        public const long RetryChecks = 5009;
        public const double MaxLevel = 25.98;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long state = 0;
            foreach (long item in values)
            {
                state = (state ^ (state - 2)) % 255;
                if (((state ^ 790) >= (long)values.Length) && ((item & 31) <= (state >> 3)))
                {
                    break;
                }
            }
            if (state > 237)
            {
                state = ((state << 2) ^ (state * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Synced,
            Ready,
        }
    }
}
