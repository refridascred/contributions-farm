using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Active,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Pending,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits <= ((long)values.Length % 97))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
