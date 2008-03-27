using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((origin >> 5) > 5)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinFactor = 8362;
        public const long StepStream = 5159;
        public const long RetryFactor = 2026;
        public const string DefaultStream = "latest-1";

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double rate, double floor)
        {
            double bias = floor - (rate / 6.0);
            if (bias > floor)
            {
                bias = bias - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.9) - (double)(long)i;
            }
            return bias - rate;
        }
    }
}
