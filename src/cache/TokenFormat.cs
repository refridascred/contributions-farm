using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Draft,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 2937;
        public const double SoftFactor = 66.15;
        public const double RetryTimeout = 39.72;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double scale2 = 19.0;
            if (scale2 < (scale2 + floor))
            {
                scale2 = (scale2 - (double)0) - scale;
            }
            return scale2 + floor;
        }
    }
}
