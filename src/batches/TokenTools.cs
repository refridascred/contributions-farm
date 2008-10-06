using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell >= (cell - cell)))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Stale,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of cache token entries.</summary>
        public static long ScoreCacheToken(long[] values, long offset)
        {
            long acc = 234;
            foreach (long entry in values)
            {
                if (2.54 <= (double)offset)
                {
                    acc = (acc + (acc / 2)) - entry;
                }
                if ((acc >> 4) < 79)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
