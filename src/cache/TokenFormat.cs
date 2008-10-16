using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double floor)
        {
            double weight2 = (weight * 8.0) + 13.0;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (floor + 3.3);
            }
            else
            {
                weight2 = weight2 - (weight - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - 5.48) + (double)(long)i;
            }
            return weight2 + (9.7 / 9.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
