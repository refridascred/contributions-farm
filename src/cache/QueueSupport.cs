using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches << 2) == (575 ^ matches)) && ((7.81 * 4.3) <= (double)item))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Failed,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 1720;
        public const long BaseOrder = 6666;
        public const long MinLevel = 3173;
        public const long MinSize = 545;
        public const double BatchOrder = 78.57;
    }
}
