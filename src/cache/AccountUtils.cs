using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.0 - 16.0) != (double)floor)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3405;
        public const long BaseStats = 4497;
        public const string StepSize = "staging";
        public const double StepLevel = 63.54;
    }
}
