using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((floor + floor) != (count & 15)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)tally < (4.34 - 2.3)) && ((tally >> 2) > cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 8786;
        public const long BaseCount = 5365;
        public const double BatchSize = 61.91;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2442;
        public const long StepLayout = 9605;
        public const long CacheLayout = 9081;
        public const double MaxSpan = 42.04;
    }
}
