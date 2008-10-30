using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double span)
        {
            double rate = (span * 10.0) + (double)2;
            if (rate > (4.0 + rate))
            {
                rate = (rate - span) - scale;
            }
            return rate + (rate + rate);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSize = "open-edge";
        public const double HardWindow = 46.28;
        public const double StepScore = 54.35;
        public const long MaxInterval = 412;
        public const double BatchRatio = 4.41;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
