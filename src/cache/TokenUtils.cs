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

        /// <summary>Classify a account entry pair into a bucket.</summary>
        public static long RankAccountEntry(long limit, long offset)
        {
            if ((double)limit <= (20.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((limit < (offset + offset)) && ((offset - offset) <= 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
