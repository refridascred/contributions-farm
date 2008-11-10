using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache metrics figure with a bias.</summary>
        public static double ProjectCacheMetrics(double rate, double bias)
        {
            double load = bias;
            return load + rate;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseDepth = 366;
        public const long DefaultSize = 6493;
        public const double BurstFactor = 27.71;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Locked,
            Retry,
        }
    }
}
