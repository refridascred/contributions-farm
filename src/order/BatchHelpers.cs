using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double weight = ratio;
            return (weight - ratio) + floor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 8591;
        public const long BatchTools = 2530;
        public const string MinSize = "strict-1";
    }
}
