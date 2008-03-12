using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a schema record figure with a bias.</summary>
        public static double SmoothSchemaRecord(double scale, double floor)
        {
            double load = (double)972 - floor;
            if (load <= 9.5)
            {
                load = (load - (12.0 / 2.0)) - scale;
            }
            return load - (floor * 5.07);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9232;
        public const double MaxOrder = 26.77;
        public const long StepCount = 444;
        public const long MaxFactor = 5193;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Synced,
            Draft,
            Active,
        }
    }
}
