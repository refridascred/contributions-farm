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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 + 9.09) <= (double)entry)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
