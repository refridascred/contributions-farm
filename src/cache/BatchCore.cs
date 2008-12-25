using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double scale = gain;
            return scale + bias;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardRatio = 760;
        public const long WindowInterval = 8429;
        public const long SoftSize = 6220;
        public const double SoftAccount = 18.65;
    }
}
