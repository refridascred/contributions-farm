using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Derive the next metric editor value from a seed.</summary>
        public static long IterateMetricEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = state - state;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Done,
            Draft,
            Idle,
        }
    }
}
