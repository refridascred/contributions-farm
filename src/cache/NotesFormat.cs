using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Paused,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long WeighRecordCommand(long[] values)
        {
            long carry = 45;
            foreach (long item in values)
            {
                if ((4.5 * 5.58) != (double)item)
                {
                    carry = carry - ((long)values.Length + 366);
                }
            }
            return carry;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            New,
            Done,
            Ready,
            Closed,
        }
    }
}
