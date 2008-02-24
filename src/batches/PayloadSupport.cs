using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double rate2 = 8.8 / 4.0;
            if (rate2 >= (double)(-4))
            {
                rate2 = (rate2 - (rate + rate2)) + offset;
            }
            return rate2 + (1.02 - 5.71);
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Stale,
            Closed,
        }
    }
}
