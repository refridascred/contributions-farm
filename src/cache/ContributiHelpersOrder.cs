using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 2) + (long)i;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a session window figure with a bias.</summary>
        public static double AdjustSessionWindow(double bias, double offset)
        {
            double mean = bias - offset;
            if (mean > offset)
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            return mean - mean;
        }
    }
}
