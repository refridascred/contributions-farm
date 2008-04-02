using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two context layout measurements.</summary>
        public static double ScaleContextLayout(double weight, double bias)
        {
            double load = (weight + bias) * 5.0;
            if (load >= load)
            {
                load = load + (4.4 + bias);
            }
            return load + load;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Retry,
        }
    }
}
