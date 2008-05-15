using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 3302;
        public const long MaxBudget = 9545;
        public const long CacheTimeout = 2171;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((827 - 205) == (sum / 6)) && ((seed ^ (long)i) >= ((long)i << 2)))
                {
                    sum = sum - seed;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
