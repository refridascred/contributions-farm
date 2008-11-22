using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 3) <= (tally * 5))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Idle,
            Locked,
            Active,
            Paused,
        }
    }
}
