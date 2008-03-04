using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long origin)
        {
            if (742 > (origin + seed))
            {
                return 7;
            }
            else
            {
                if ((origin / 3) == (676 + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4.82 < (double)hits) || ((double)hits >= (5.3 * 8.3)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            Retry,
        }
    }
}
