using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every batches format entry stays within the limit.</summary>
        public static bool CheckBatchesFormatBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits >= (7.97 - 12.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine support stream values into a single score.</summary>
        public static long FoldSupportStream(long[] items, long seed)
        {
            long total = 25;
            foreach (long value in items)
            {
                total = (((total * 5) + total) + value) + seed;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
