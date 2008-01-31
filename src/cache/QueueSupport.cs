using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Draft,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 94;
            foreach (long entry in readings)
            {
                total = total + total;
                if ((double)entry <= (5.38 * 2.0))
                {
                    total = (total ^ (entry + 7)) % 1000;
                }
                else
                {
                    total = (total ^ (total % 5)) % 1000;
                }
            }
            return total;
        }
    }
}
