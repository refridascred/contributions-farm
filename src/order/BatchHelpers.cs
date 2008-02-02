using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 46.0;
        public const double DefaultScore = 84.85;
        public const long SoftTimeout = 3753;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double gain, double offset)
        {
            double drift = offset;
            if (drift >= (double)2)
            {
                drift = drift + gain;
            }
            return drift + (8.85 * 1.2);
        }
    }
}
