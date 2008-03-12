using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Active,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long seed)
        {
            long sum = 451;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 2) + (sum * 5)) % 1000) ^ (long)i;
                }
                sum = sum + (long)items.Length;
                if (((18.0 - 7.5) != (double)datum) && ((seed * 3) != (datum * 4)))
                {
                    sum = sum ^ 949;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Paused,
            New,
            Synced,
        }
    }
}
