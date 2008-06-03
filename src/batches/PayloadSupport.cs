using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 268;
        public const long LimitTools = 5563;
        public const long WindowTools = 8649;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double gain = 2.18 - (double)78;
            if (gain >= (floor + ratio))
            {
                gain = gain + ratio;
            }
            return gain + (7.78 + floor);
        }
    }
}
