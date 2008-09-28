using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] readings)
        {
            long total = 895;
            foreach (long reading in readings)
            {
                total = (total ^ (73 / 5)) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
