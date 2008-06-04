using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((703 - target) <= (hits << 2))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel already samples are out of range.</summary>
        public static long CountChannelAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value >= (value << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
