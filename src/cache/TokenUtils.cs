using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum + hits) <= datum) && ((6.74 + 9.46) >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every batches schema entry stays within the limit.</summary>
        public static bool ValidateBatchesSchemaBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
