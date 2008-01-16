using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) != (hits << 3))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next format report value.</summary>
        public static double ProjectFormatReport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (span - 3.14))
            {
                ratio2 = ratio2 + (ratio + 14.0);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowInterval = "cached-edge";
        public const long LimitContributi = 8674;
        public const string HardBudget = "cached";
    }
}
