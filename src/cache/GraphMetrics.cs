using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double ratio = (double)92 + (double)0;
            if (ratio >= 15.0)
            {
                ratio = ratio - (scale - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (8.9 - ratio)) + (double)(long)i;
            }
            return ratio + (span * 8.0);
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5422;
        public const double WindowFactor = 59.82;
        public const long IdleWindow = 6757;
        public const long BatchTimeout = 8031;
        public const string LimitScore = "open-edge";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
