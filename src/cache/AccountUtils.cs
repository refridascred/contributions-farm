using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 3) <= (count & 7)) && (((-35) / 4) <= (25 - reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleWidth = 6676;
        public const long MinBudget = 3856;
        public const string MinWidth = "open-1";
        public const long LimitChannel = 9444;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Locked,
            Failed,
        }
    }
}
