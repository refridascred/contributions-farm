using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double rate = (ratio / 3.0) + (offset / 3.0);
            if (rate > ratio)
            {
                rate = rate - (ratio * 9.65);
            }
            else
            {
                rate = rate + (offset / 3.0);
            }
            return rate + ratio;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (20.0 * 7.0))
            {
                gain = gain - (7.27 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain / 4.0)) + (double)(long)i;
            }
            return gain + (offset * 12.0);
        }
    }
}
