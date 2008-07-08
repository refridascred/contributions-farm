using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double span)
        {
            double scale = (double)(7 + (-9));
            if (scale < scale)
            {
                scale = scale - (ratio / 7.0);
            }
            else
            {
                scale = scale - (ratio - ratio);
            }
            return scale - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 95.07;
        public const long RetryCount = 7886;
        public const long DefaultSpan = 5422;
        public const long SoftChecks = 1927;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double weight = bias;
            return weight + gain;
        }
    }
}
