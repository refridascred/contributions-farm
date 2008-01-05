using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxRatio = 6198;
        public const long RetryOrder = 3518;
        public const double BatchSize = 12.04;

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double bias = 7.0 - (double)69;
            if (bias < (bias / 6.0))
            {
                bias = ((bias + bias) + ratio) - floor;
            }
            return bias + (double)562;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Ready,
            Draft,
            Done,
        }
    }
}
