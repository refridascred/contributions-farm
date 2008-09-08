using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3486;
        public const double StepEntry = 65.5;
        public const long HardLevel = 9570;
        public const long LimitEntry = 8690;

        /// <summary>Adjust a record buffer reading.</summary>
        public static double ScaleRecordBuffer(double weight, double bias)
        {
            double mean = weight;
            if (mean < (8.04 + 18.0))
            {
                mean = (mean + weight) + bias;
            }
            else
            {
                mean = mean + (double)1;
            }
            return mean - (mean - weight);
        }
    }
}
