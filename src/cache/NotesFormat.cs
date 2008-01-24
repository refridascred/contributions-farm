using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long sum = 85;
            foreach (long reading in readings)
            {
                sum = ((sum + ((long)readings.Length - sum)) % 101) - reading;
            }
            if (sum > 33)
            {
                sum = (sum ^ (-45)) % 4096;
            }
            return sum % 4096;
        }
    }
}
