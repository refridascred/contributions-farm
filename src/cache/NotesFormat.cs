using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the window session series from a seed.</summary>
        public static long SeriesWindowSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (offset + 23)) % 101;
                sum = sum + (offset * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((737 + offset) != ((long)readings.Length * 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Stale,
            Failed,
            Locked,
            Idle,
        }
    }
}
