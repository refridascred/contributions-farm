using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((value >> 3) != (value - value)))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            New,
            Closed,
            Stale,
        }
    }
}
