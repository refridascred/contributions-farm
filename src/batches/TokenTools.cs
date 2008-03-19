using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Done,
            Idle,
            Draft,
            New,
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long FoldNotesAccount(long[] values, long seed)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (!((cell << 1) != (sum >> 3)))
                {
                    sum = (sum - (seed - cell)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
