using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Retry,
            Pending,
            Locked,
            Dropped,
        }

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
