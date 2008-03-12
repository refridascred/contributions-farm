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

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double scale = 9.05;
            if (scale >= bias)
            {
                scale = (scale - bias) + floor;
            }
            else
            {
                scale = scale - 4.11;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)54) + (double)(long)i;
            }
            return scale + (double)63;
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
