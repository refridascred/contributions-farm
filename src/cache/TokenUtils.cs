using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) == (bound ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
