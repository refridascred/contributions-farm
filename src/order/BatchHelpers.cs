using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 77.95;
        public const long MinTimeout = 4657;
        public const double DefaultScore = 8.06;
        public const long CacheFilter = 9960;

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double bias = offset;
            return (bias + (double)3) + gain;
        }
    }
}
