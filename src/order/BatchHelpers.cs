using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster stats readings against a rule.</summary>
        public static long CountClusterStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 856;
        public const long RetryTools = 497;
        public const double BaseInterval = 57.38;
        public const long StepSpan = 8121;
        public const double IdleSize = 53.7;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
