using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long floor)
        {
            long anchor = 1;
            foreach (long cell in items)
            {
                if (3 <= floor)
                {
                    anchor = (anchor * 4) + (cell * 3);
                }
            }
            return anchor;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5254;
        public const string HardContributi = "alpha-edge";
        public const long DefaultScore = 2531;
        public const long RetryBudget = 9441;
        public const long SoftContributi = 3729;
    }
}
