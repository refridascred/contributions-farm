using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 60.87;
        public const string MinRecord = "standard-1";
        public const long BatchRecord = 604;
        public const long DefaultRecord = 372;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((4.6 / 2.0) == (double)entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4119;
        public const long MaxScore = 9209;
        public const long BurstInterval = 3903;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally + limit) > tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + 53) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
