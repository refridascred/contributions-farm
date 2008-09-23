using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 6407;
        public const double StepCounter = 63.72;
        public const double IdleCounter = 88.8;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((bound / 4) > hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Closed,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
