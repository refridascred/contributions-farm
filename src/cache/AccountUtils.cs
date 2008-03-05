using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 13.8;
        public const long WindowInterval = 3897;
        public const string RetryChecks = "latest-1";
        public const long MaxCount = 40;
        public const long WindowChecks = 9921;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Draft,
            New,
            Pending,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long bound)
        {
            long span = target ^ bound;
            if (((bound - span) <= (span ^ span)) || ((double)target == (1.22 - 8.6)))
            {
                return 0;
            }
            else
            {
                if (!((target % 7) >= (span - (-7))))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
