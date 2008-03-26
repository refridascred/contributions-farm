using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = (double)(427 - 0);
            if (gain > 11.0)
            {
                gain = (gain - (bias2 - 20.0)) - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (bias2 * 1.14);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxDepth = 7888;
        public const long BatchMetrics = 3538;
        public const string IdleMetrics = "primary-v2";
    }
}
