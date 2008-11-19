using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 90;
            foreach (long reading in items)
            {
                total = (((total << 2) ^ total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits != (7.6 + 8.28))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long limit)
        {
            long total = 1;
            foreach (long item in items)
            {
                if ((695 * 2) >= (794 + limit))
                {
                    total = (total ^ (limit >> 3)) + item;
                }
            }
            return total;
        }
    }
}
