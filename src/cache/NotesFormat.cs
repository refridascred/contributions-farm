using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long total = 2;
            foreach (long reading in values)
            {
                total = (total ^ (reading / 4)) + step;
            }
            return total;
        }
    }
}
