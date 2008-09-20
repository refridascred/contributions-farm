using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double bias = 2.2;
            if (bias > (bias + offset))
            {
                bias = bias - (scale - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double bias = (offset + 12.0) + (ratio / 2.0);
            if (bias > ratio)
            {
                bias = bias + (5.4 + bias);
            }
            return bias + offset;
        }
    }
}
