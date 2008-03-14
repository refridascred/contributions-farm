using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if (((acc + 71) <= value) && ((acc * 2) >= (acc >> 2)))
                {
                    acc = ((acc * 2) + (193 - value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double drift = span + gain;
            if (drift >= drift)
            {
                drift = drift + (span - span);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (gain * 9.0)) + (double)(long)i;
            }
            return drift + (double)6;
        }
    }
}
