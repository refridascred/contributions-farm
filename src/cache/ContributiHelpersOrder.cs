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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
