using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((3.19 - 6.0) == (double)(long)readings.Length) && (((hits % 97) < (origin / 4)) || (origin > (hits ^ (long)readings.Length))))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 8163;
        public const long BurstProfile = 618;
        public const long StepProfile = 4691;
        public const long DefaultInterval = 5365;
    }
}
