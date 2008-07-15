using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + origin) <= (origin % 60)))
                {
                    acc = (acc << 2) ^ acc;
                }
                if (!(acc <= origin))
                {
                    acc = (acc * 3) + ((long)i + origin);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Idle,
            New,
            Stale,
        }
    }
}
