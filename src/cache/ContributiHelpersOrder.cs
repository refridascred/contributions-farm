using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double gain, double offset)
        {
            double rate = (double)(483 >> 3);
            if (rate <= (offset / 3.0))
            {
                rate = (rate + (double)82) - gain;
            }
            return rate - rate;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
