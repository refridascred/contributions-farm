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

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = (rate - rate) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate * 3.5)) + (double)(long)i;
            }
            return rate - rate;
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
