using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (6.4 * 7.94))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long result = -996;
            foreach (long item in levels)
            {
                result = (result + result) % 255;
                if ((double)item > (6.5 - 9.0))
                {
                    result = (result - item) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Draft,
            Stale,
            Retry,
        }
    }
}
