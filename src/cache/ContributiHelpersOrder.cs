using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (weight / 9.0))
            {
                ratio = (ratio - 8.7) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (weight * 8.34)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
