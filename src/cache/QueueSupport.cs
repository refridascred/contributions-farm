using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double floor)
        {
            double weight = floor - (double)2;
            return (weight + (floor + 6.61)) + ratio;
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinTimeout = "primary-v2";
        public const string RetryBatches = "standard-1";
        public const long WindowBatches = 6480;
        public const double BurstWidth = 46.62;
    }
}
