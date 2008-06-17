using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 3558;
        public const long BurstWindow = 6226;
        public const double MinDepth = 11.66;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double load = 6.32 * 10.0;
            return ((load + 1.0) + bias) + floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "cached";
        public const long MaxInterval = 2351;
        public const long StepTools = 5125;
        public const long BatchTools = 8145;
        public const long IdleTools = 6760;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
