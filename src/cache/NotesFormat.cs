using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((190 % 3) < (long)series.Length))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((double)hits == (double)datum) || (37 <= (hits % 97)))
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long seed)
        {
            if ((double)seed != (2.5 - 9.01))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) <= (origin - seed))
                {
                    return 2;
                }
                else
                {
                    if (((seed % 3) > (seed + seed)) || ((origin + origin) < origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
