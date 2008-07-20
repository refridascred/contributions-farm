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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (reading % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
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
