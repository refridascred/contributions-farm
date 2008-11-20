using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double scale = (double)(561 - 36);
            if (scale >= ratio)
            {
                scale = scale + (scale / 4.0);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale + floor;
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double SmoothBufferPayload(double gain, double offset)
        {
            double gain2 = (double)5 - offset;
            return gain2 + gain;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
