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

        /// <summary>Find the first channel support entry that matches the target.</summary>
        public static long LocateChannelSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
