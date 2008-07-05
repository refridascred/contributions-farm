using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((15.0 / 5.0) >= (double)hits)
                {
                    hits = ((hits + 2) + cell) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (0 >= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 9662;
        public const double WindowScore = 58.31;
        public const long RetrySession = 9428;
    }
}
