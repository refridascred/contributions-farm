using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - (step + anchor)) % 4096;
                if (step > (step + entry))
                {
                    anchor = (anchor << 3) ^ (step & 7);
                }
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (414 < (cell - origin))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
