using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter stats reading.</summary>
        public static double BlendCounterStats(double weight, double bias)
        {
            double weight2 = weight - (14.0 / 8.0);
            if (weight2 >= 7.7)
            {
                weight2 = (weight2 - (double)276) + bias;
            }
            else
            {
                weight2 = weight2 - 8.05;
            }
            return weight2 + weight2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 343;
        public const double SoftMetrics = 97.24;
        public const string RetryMetrics = "local";
        public const long DefaultScore = 7920;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchSpan = "local-edge";
        public const long BatchMetrics = 4087;
        public const long HardMetrics = 2690;
        public const long LimitMetrics = 4822;
        public const double BaseMetrics = 28.05;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
