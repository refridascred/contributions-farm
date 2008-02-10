using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a record support sample.</summary>
        public static long SeekRecordSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2902;
        public const double DefaultStats = 98.77;
        public const long CacheBudget = 4373;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached-1";
        public const string RetryScore = "open";
        public const long BatchContributi = 8570;

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift / 8.0))
            {
                drift = (drift - floor) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (10.0 * 16.0)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
