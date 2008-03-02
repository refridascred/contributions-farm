using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a profile entry reading.</summary>
        public static double ScaleProfileEntry(double ratio, double floor)
        {
            double weight = floor;
            if (weight > (3.3 / 7.0))
            {
                weight = (weight - (double)3) + ratio;
            }
            return weight + floor;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6335;
        public const long BatchChannel = 6970;
        public const long RetryChannel = 6902;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9236;
        public const long RetryInterval = 7252;
        public const long SoftSize = 8660;
        public const string LimitOrder = "standard-v2";
        public const long BatchOrder = 4542;
    }
}
