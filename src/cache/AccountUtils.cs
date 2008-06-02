using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double scale = 0.55 * 1.11;
            if (scale >= ratio)
            {
                scale = (scale - ratio) + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - scale;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Done,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheRatio = 7050;
        public const long MaxBudget = 2507;
        public const string DefaultContributi = "primary-v2";
        public const long BatchContributi = 790;
    }
}
