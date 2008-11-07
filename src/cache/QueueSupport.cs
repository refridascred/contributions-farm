using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 6) <= 7)
                {
                    hits = ((hits + 3) + item) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Synced,
            Draft,
            New,
            Dropped,
        }
    }
}
