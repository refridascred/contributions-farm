using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 42.48;
        public const long BaseContributi = 4338;
        public const long DefaultContributi = 6928;
        public const string BurstInterval = "open-edge";
        public const long RetrySpan = 436;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
