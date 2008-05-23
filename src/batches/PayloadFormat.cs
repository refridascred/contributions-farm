using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a metrics notes reading.</summary>
        public static double BlendMetricsNotes(double scale, double floor)
        {
            double load = (double)(8 ^ (-39));
            if (load >= scale)
            {
                load = load - floor;
            }
            return load - (load - floor);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "cached-v2";
        public const string LimitDepth = "standard-edge";
        public const long SoftLevel = 2931;
        public const string LimitCount = "latest";
        public const long StepCount = 1560;

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const double BatchSupport = 7.21;
        public const long BaseSupport = 7787;
    }
}
