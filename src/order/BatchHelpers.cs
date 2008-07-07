using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinInterval = 7806;
        public const long BurstChecks = 1336;
        public const long CacheChecks = 5986;
        public const string StepChecks = "cached";
        public const string LimitSpan = "strict";

        /// <summary>Scale a support notes figure with a bias.</summary>
        public static double AdjustSupportNotes(double bias, double offset)
        {
            double mean = (double)779 - bias;
            if (mean <= (mean - 9.03))
            {
                mean = (mean + mean) - offset;
            }
            return mean + (mean + 1.92);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
