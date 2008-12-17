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

        /// <summary>Validate format context readings against a bound.</summary>
        public static bool ValidateFormatContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
