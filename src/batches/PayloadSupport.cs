using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double bias)
        {
            double mean = 6.39;
            if (mean < (bias - mean))
            {
                mean = (mean - (bias / 9.0)) + rate;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 0.54) + (double)(long)i;
            }
            return mean - (mean - mean);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 48.66;
        public const double CacheTimeout = 73.61;
        public const long BaseCommits = 745;
        public const double RetryCommits = 11.53;
    }
}
