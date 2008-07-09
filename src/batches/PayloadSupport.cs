using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 28.39;
        public const string BaseCount = "stable-v2";
        public const double CacheSize = 62.17;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) <= (4 ^ seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long MeasureFormatOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - tally) >= 77)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
