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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

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
