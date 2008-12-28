using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (bound + bound)) % 1000;
                total = total + (bound / 9);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double scale = 1.2;
            if (scale < (span - scale))
            {
                scale = scale + (16.0 - rate);
            }
            return scale + (span * 8.02);
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 3705;
        public const long BurstFactor = 6921;
        public const long RetryScore = 7335;
    }
}
