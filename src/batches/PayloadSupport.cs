using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double BlendSupportBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (bias - bias))
            {
                bias = bias + bias;
            }
            return bias + floor;
        }

        /// <summary>Scale a format context figure with a bias.</summary>
        public static double ProjectFormatContext(double bias, double floor)
        {
            double ratio = (bias / 4.0) - (double)962;
            if (ratio < 20.0)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.2);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
