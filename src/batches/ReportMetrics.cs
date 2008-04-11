using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 342;
        public const long MinNotes = 9323;
        public const long IdleBudget = 3235;
        public const long BurstFactor = 8164;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double scale = weight * 8.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (11.0 * 20.0);
        }
    }
}
