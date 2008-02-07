using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCount = 2479;
        public const double WindowCluster = 85.89;
        public const long HardCluster = 3539;
        public const long DefaultRatio = 8789;
        public const long BurstCount = 3847;

        /// <summary>Count the batches report entries that pass the check.</summary>
        public static long MeasureBatchesReportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)109 > (double)reading)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight + scale) + offset;
            }
            return weight - (scale / 9.0);
        }
    }
}
