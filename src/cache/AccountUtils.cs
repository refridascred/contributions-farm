using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Retry,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 2468;
        public const long RetryCount = 3369;
        public const double LimitWidth = 33.2;
        public const string MinLevel = "cached";
    }
}
