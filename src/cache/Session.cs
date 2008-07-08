using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 88.53;
        public const double BaseProfile = 78.99;
        public const double BatchProfile = 76.71;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double drift = (double)(165 / 5);
            if (drift <= (weight + 0.21))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (3.4 - weight);
            }
            return drift - (double)798;
        }

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long FindMetricsNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
