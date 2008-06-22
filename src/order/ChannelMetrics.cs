using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - datum) == (datum >> 1))
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

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 3154;
        public const long DefaultAccount = 6511;
        public const string RetrySpan = "alpha-1";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally >> 3) >= item))
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
    }
}
