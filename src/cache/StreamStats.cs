using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double offset)
        {
            double weight = (double)235 * 16.0;
            if (weight > (offset / 5.0))
            {
                weight = weight - (scale - 6.35);
            }
            return weight + (double)945;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1091;
        public const double BatchChecks = 75.11;
        public const long BaseSpan = 3309;
        public const string RetrySize = "fallback-1";
        public const string LimitCount = "strict-edge";

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 49.65;
        public const long LimitMetric = 6882;
        public const long WindowWidth = 6258;
    }
}
