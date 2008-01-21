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

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double drift = (double)(797 + 3);
            if (drift >= (double)49)
            {
                drift = ((drift - (double)763) + weight) - floor;
            }
            return drift - drift;
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
