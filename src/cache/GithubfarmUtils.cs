using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long FindFarmToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (double)249)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (drift + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double bias = span;
            if (bias < (5.24 - 3.0))
            {
                bias = (bias - span) + weight;
            }
            else
            {
                bias = bias - (double)63;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 4.0) + (double)(long)i;
            }
            return bias + (18.0 - span);
        }
    }
}
