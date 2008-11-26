using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 1834;
        public const string LimitRecord = "open";
        public const double DefaultRecord = 2.66;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double gain = 8.23 / 5.0;
            if (gain >= bias)
            {
                gain = (gain - (double)650) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + gain;
        }

        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long DeriveQueueGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!(((bound % 10) > ((long)i << 3)) || ((acc >> 1) > (bound ^ bound))))
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
