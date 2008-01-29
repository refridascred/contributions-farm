using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((seed ^ 1) < (hits / 7))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
