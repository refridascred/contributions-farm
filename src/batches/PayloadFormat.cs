using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 90.78;
        public const long BaseWidth = 7414;
        public const string RetryContributi = "legacy-1";
        public const long CacheBudget = 3819;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route channel value.</summary>
        public static double AdjustRouteChannel(double ratio, double floor)
        {
            double mean = (ratio * 3.2) + (ratio - 9.5);
            if (mean >= (mean * 9.0))
            {
                mean = (mean + (ratio * 1.6)) - floor;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio * 3.0)) - (double)(long)i;
            }
            return mean - (double)750;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
