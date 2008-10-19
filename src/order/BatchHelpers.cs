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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((0.8 + 3.0) > (double)origin)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
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
