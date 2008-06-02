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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 183;
        public const long RetryRatio = 5504;
        public const long LimitRatio = 9698;
        public const double MaxRoute = 59.94;
    }
}
