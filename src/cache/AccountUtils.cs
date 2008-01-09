using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - floor) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            New,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
