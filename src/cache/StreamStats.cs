using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = acc - (long)i2;
                }
                double drift = (double)(long)i + 4.0;
                if ((double)96 <= drift)
                {
                    drift = drift + (4.08 / 5.0);
                    acc = (acc + (acc >> 4)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double mean = floor;
            return (mean + (2.0 / 5.0)) + weight;
        }
    }
}
