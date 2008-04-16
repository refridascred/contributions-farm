using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6865;
        public const long HardBatch = 7340;
        public const string BurstLevel = "fallback-edge";

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool GuardMetricReportBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 6; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
