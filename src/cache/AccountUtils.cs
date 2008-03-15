using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleWidth = 90.88;
        public const long SoftMetric = 3103;
        public const double MinMetric = 98.98;

        /// <summary>Blend two batches already measurements.</summary>
        public static double BlendBatchesAlready(double gain, double floor)
        {
            double gain2 = 1.6;
            if (gain2 < (double)(-877))
            {
                gain2 = (gain2 + (double)8) - floor;
            }
            return gain2 + gain;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Stale,
            Draft,
            Synced,
            New,
        }
    }
}
