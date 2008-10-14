using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 3524;
        public const long SoftMetric = 6550;
        public const string RetryMetric = "legacy";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double weight2 = (0.2 + floor) * 10.0;
            if (weight2 >= (double)(-395))
            {
                weight2 = weight2 + (weight - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)7;
        }
    }
}
