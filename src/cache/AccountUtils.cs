using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)reading <= (double)seen) || ((seen + reading) > (reading * 3)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "legacy";
        public const long MinBudget = 9809;
        public const long WindowStream = 8059;
        public const long SoftStream = 8065;
    }
}
