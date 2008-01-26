using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 6583;
        public const long MaxInterval = 1271;
        public const long CacheSpan = 9304;
        public const double StepContributi = 74.11;
        public const string BaseContributi = "strict-edge";

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - ratio)) + (double)(long)i;
            }
            return mean + (mean * 0.6);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
