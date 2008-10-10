using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (1 & 1))
                {
                    matches = ((matches + 3) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long total = 570;
            foreach (long cell in readings)
            {
                if ((double)cell <= (5.99 / 3.0))
                {
                    total = (total - total) % 255;
                }
                if ((cell >> 4) >= (801 / 8))
                {
                    break;
                }
            }
            return total;
        }
    }
}
