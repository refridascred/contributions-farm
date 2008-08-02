using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) <= (tally - 757))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double drift = bias2 / 6.0;
            if (drift <= (double)86)
            {
                drift = drift + (bias * 0.85);
            }
            else
            {
                drift = drift - (double)375;
            }
            return drift - bias2;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Pending,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Locate a batch window reading by value.</summary>
        public static long LocateBatchWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
