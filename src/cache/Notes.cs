using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)(-99)) + (double)(long)i) - ratio;
            }
            return mean - (bias + bias);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 4941;
        public const long MaxGraph = 2066;
        public const string IdleInterval = "strict-1";
        public const long LimitGraph = 5442;
    }
}
