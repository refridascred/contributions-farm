using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Audit record filter readings against a rule.</summary>
        public static long MeasureRecordFilterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset * 2) >= (offset + hits))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Synced,
            Pending,
        }
    }
}
