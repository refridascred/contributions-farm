using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Idle,
            Done,
            Queued,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 3661;
        public const double BurstScore = 60.22;
        public const long BaseStats = 7478;
        public const double CacheRatio = 47.74;

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool ValidateQueueEntryRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
