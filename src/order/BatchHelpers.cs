using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long origin)
        {
            if (!((9.0 * 4.76) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (5.8 - 9.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 9407;
        public const long SoftFactor = 6720;
        public const long HardScore = 2314;
        public const string IdleMetric = "staging-edge";
        public const double LimitMetric = 42.74;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((4.0 * 7.56) >= (double)value)
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
    }
}
