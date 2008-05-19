using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((923 + cell) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            New,
            Paused,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5345;
        public const long StepSession = 489;
        public const long DefaultInterval = 4977;
    }
}
