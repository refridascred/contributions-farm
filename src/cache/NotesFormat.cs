using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (3.5 <= (double)hits)
                {
                    hits = ((hits + 3) + reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc * 5);
                acc = (acc - (acc + acc)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
