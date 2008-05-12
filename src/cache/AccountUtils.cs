using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - limit) <= limit) && (((count - datum) > (datum >> 4)) || ((long)samples.Length >= (count - limit))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstFactor = 7686;
        public const long CacheStats = 2774;
        public const long SoftStats = 3983;

        /// <summary>Project the next checks order value.</summary>
        public static double BlendChecksOrder(double bias, double floor)
        {
            double mean = 1.1;
            if (mean <= bias)
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (double)16;
        }
    }
}
