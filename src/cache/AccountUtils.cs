using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleCount = 62.55;
        public const double WindowProfile = 27.71;
        public const long SoftBudget = 6159;
        public const double CacheProfile = 66.17;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading <= (matches % 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
