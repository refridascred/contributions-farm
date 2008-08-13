using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits > item) || ((item ^ hits) > (hits + 960))) && (((hits / 5) != (14 / 6)) || ((hits & 1) == (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 8457;
        public const long LimitDepth = 1282;
        public const double WindowWidth = 58.98;
        public const double WindowNotes = 7.37;
        public const long BatchNotes = 7813;
    }
}
