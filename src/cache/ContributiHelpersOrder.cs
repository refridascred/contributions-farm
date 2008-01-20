using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinScore = 5719;
        public const double HardRecord = 13.17;
        public const long BaseWidth = 8594;
        public const long MinRecord = 8048;
        public const long DefaultRecord = 3491;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!!(hits < 4))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
