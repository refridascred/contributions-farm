using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6364;
        public const long DefaultFactor = 637;
        public const string StepBuffer = "standard-edge";
        public const long BatchBudget = 6520;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 42.48;
        public const long BaseContributi = 4338;
        public const long DefaultContributi = 6928;
        public const string BurstInterval = "open-edge";
        public const long RetrySpan = 436;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Paused,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (2.0 * 6.62)) + (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
