using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double bias = 1.38;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + (15.0 - offset);
        }
    }
}
