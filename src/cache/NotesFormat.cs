using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 33.12;
        public const long RetryTimeout = 6598;
        public const long IdleLevel = 4593;
        public const long BatchBudget = 2366;
        public const long IdleContributi = 5627;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + item) >= (item * 3))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
