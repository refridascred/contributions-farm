using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - matches) != (value ^ matches))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits + reading) != (hits << 1)) && ((hits + 8) > reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data)
        {
            long acc = 97;
            foreach (long entry in data)
            {
                acc = (acc << 3) ^ 468;
                if ((double)entry < (8.3 / 7.0))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
