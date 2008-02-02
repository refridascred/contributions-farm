using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Locked,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((lane - lane) >= lane)
            {
                return 4;
            }
            else
            {
                if (((28 ^ 390) < (lane - floor)) || ((7.54 - 2.92) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every batches counter entry stays within the limit.</summary>
        public static bool GuardBatchesCounterRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
