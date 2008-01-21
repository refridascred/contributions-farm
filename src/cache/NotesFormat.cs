using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long total = 483;
            foreach (long datum in readings)
            {
                total = (((total ^ (total - (long)readings.Length)) % 1000) - datum) - target;
            }
            return total;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Synced,
            Paused,
            Locked,
            Done,
        }
    }
}
