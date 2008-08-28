using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double scale = 18.0;
            if (scale >= (gain * 4.85))
            {
                scale = (scale + (gain * 13.0)) - span;
            }
            else
            {
                scale = scale + (gain / 7.0);
            }
            return scale + (0.4 - gain);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 9.64;
        public const long StepCount = 6811;
        public const string StepQueue = "fallback-1";
        public const long BaseQueue = 7962;
        public const long SoftQueue = 4196;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
