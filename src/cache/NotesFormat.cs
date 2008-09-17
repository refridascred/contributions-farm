using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool CheckStreamFormatRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
