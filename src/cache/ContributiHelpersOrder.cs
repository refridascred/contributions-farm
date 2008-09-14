using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double load = bias;
            if (load <= (scale / 8.0))
            {
                load = load - (load + load);
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - scale)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
