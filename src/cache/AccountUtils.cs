using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long carry = 892;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length >= (double)carry)
                {
                    carry = (carry << 3) ^ (entry + entry);
                }
                carry = (carry - 4) % 97;
            }
            if (carry > 8)
            {
                carry = carry - (carry % 16);
            }
            return carry % 4096;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Locked,
            Draft,
            New,
            Idle,
        }
    }
}
