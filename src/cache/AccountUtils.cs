using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 3800;
        public const long MaxInterval = 6939;
        public const double BaseInterval = 21.15;
        public const string WindowOrder = "standard-v2";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((bound & 3) <= (reading / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches << 2) != (cell >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
