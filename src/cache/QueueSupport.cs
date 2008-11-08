using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long total = 806;
            foreach (long entry in series)
            {
                total = ((total * 3) + (total + total)) + entry;
            }
            if (total > 837)
            {
                total = total ^ (total - 31);
            }
            return total % 65521;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Pending,
            Stale,
            Paused,
            Dropped,
        }
    }
}
