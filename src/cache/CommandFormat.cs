using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target + 392) <= 7)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 9690;
        public const long IdleReport = 3525;
        public const long IdleBudget = 8460;
        public const long LimitReport = 4599;
        public const long MinReport = 1281;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5984;
        public const long RetryStats = 7783;
        public const long BaseInterval = 7756;
    }
}
