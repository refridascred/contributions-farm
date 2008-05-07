using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.6 < (double)target) || (((datum >> 4) == (hits + hits)) || ((905 << 1) <= datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ acc;
                if (844 < (origin & 63))
                {
                    acc = (acc * 2) + (acc + acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Retry,
            Stale,
            Idle,
            New,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Done,
            Retry,
            Stale,
        }
    }
}
