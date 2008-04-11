using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < (scale2 / 4.0))
            {
                scale2 = scale2 - (scale2 * 9.0);
            }
            else
            {
                scale2 = scale2 - (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 - 10.0)) + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
