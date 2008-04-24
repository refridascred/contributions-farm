using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < 40)
                {
                    count = ((count + 2) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double mean = 19.0;
            if (mean < ratio)
            {
                mean = mean + (span - ratio);
            }
            return mean - mean;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 2660;
        public const double HardAlready = 83.39;
        public const double LimitAlready = 65.42;
    }
}
