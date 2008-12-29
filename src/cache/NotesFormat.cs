using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stats filter readings against a bound.</summary>
        public static bool CheckStatsFilterBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Pending,
            New,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 6142;
        public const long BatchAccount = 2580;
        public const long StepAccount = 1208;
        public const long RetryBudget = 3558;
        public const long BurstRatio = 6258;
    }
}
