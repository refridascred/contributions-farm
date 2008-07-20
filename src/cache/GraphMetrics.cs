using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double ratio = bias2 / 8.0;
            if (ratio >= bias)
            {
                ratio = ratio - (6.15 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)49) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits & 255) == (datum << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 1055;
        public const double HardChecks = 94.68;
        public const long MaxRatio = 4240;
        public const long MaxChecks = 9368;
    }
}
