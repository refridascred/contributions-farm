using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                carry = (carry + (entry >> 3)) % 97;
            }
            if (carry > 7)
            {
                carry = (carry * 2) + (871 * 2);
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many report order samples are out of range.</summary>
        public static long MeasureReportOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((seen - seen) >= (value + 0)) || !((double)value >= (9.0 + 4.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }
    }
}
