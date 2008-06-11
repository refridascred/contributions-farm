using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long BaseTimeout = 6303;
        public const long LimitRatio = 3387;
        public const double WindowDepth = 75.99;
        public const long RetrySchema = 4618;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSize = 6425;
        public const string RetryRecord = "alpha-edge";
        public const long MinDepth = 8081;
        public const string DefaultInterval = "cached-1";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value == (double)(-584))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
