using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen << 1) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 7.8)
                {
                    hits = ((hits + 1) ^ value) - seed;
                }
            }
            return hits;
        }
    }
}
