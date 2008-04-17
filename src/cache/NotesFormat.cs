using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryInterval = 5459;
        public const long CacheChecks = 222;
        public const long SoftBudget = 4014;
        public const double MinChecks = 56.45;
        public const long BurstTimeout = 6565;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long result = 276;
            foreach (long cell in readings)
            {
                if (((offset - offset) <= (17 >> 5)) && ((double)cell > (5.0 - 4.2)))
                {
                    result = (result << 2) ^ (offset * 3);
                }
            }
            return result % 1000;
        }
    }
}
