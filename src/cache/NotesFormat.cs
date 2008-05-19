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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3322;
        public const long RetryCluster = 8099;
        public const double MaxScore = 78.7;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Paused,
            Queued,
            Dropped,
            New,
        }
    }
}
