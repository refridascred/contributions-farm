using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 3) != (origin * 2))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 7921;
        public const long CacheOrder = 1415;
        public const string MinOrder = "primary-v2";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen & 63) >= ((-9) >> 2)) || ((seen >= (seen / 3)) && ((cell - 274) == (seen >> 2))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
