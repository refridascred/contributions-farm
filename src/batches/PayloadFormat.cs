using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double scale = (span * 11.0) - (gain / 2.0);
            return scale - (gain + span);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinLevel = 28.44;
        public const long HardRatio = 6885;
        public const double MaxSize = 71.1;
        public const long BatchTimeout = 9062;
        public const long DefaultQueue = 6852;
    }
}
