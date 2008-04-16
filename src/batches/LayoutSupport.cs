using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double SmoothCacheLayout(double rate, double bias)
        {
            double weight = bias;
            return (weight - weight) + rate;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading == (8.3 * 1.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchTimeout = 2412;
        public const double BatchFactor = 55.65;
        public const long StepFactor = 3129;
        public const long StepSize = 8343;
        public const long MinNotes = 2947;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
